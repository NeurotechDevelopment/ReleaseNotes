﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using CommonDataAndUtilities.DataClassAdapters;
using CommonDataAndUtilities.GitRestApiDataClasses;
using GitTfsRestServiceProxy.Extensions;
using RestSharp;
using RestSharp.Authenticators;

namespace GitTfsRestServiceProxy
{
	public static class GitProjectRepository
	{
		private static  int MaxRecordCount => Convert.ToInt32(ConfigurationManager.AppSettings["MaxCollectionSize"]);

		#region Public methods

		#region Repository queries

		public static Collection<Repository> GetRepositories()
		{
			var client = CreateClient();
			
			var request = CreateGetRequest(GitAddressBuilder.RepositoriesResource);

			var response = client.Execute(request);
			return response.ToCollection<Repository>();
		}

		#endregion

		#region Commits queries

		/// <summary>
		/// https://www.visualstudio.com/en-us/docs/integrate/api/git/commits
		/// </summary>
		public static Collection<Commit> GetCommits(Guid repositoryId, string branchName = null)
		{
			// https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/commits?api-version=1.0
			var client = CreateClient();
			var request = CreateGetRequest(GitAddressBuilder.RepositoriesResource + "/{repositoryId}/commits");
			request.AddUrlSegment("repositoryId", repositoryId.ToString());
			if (!string.IsNullOrWhiteSpace(branchName))
			{
				request.AddQueryParameter("branch", branchName);
			}

			var response = client.Execute(request);
			return response.ToCollection<Commit>();
		}

		public static Commit GetCommit(Guid repositoryId, string commitId)
		{
			//https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/commits/be67f8871a4d2c75f13a51c1d3c30ac0d74d4ef4?api-version=1.0
			var client = CreateClient();
			var request = CreateGetRequest(GitAddressBuilder.RepositoriesResource + "/{repositoryId}/commits/{commitId}");
			request.AddUrlSegment("repositoryId", repositoryId.ToString());
			request.AddUrlSegment("commitId", commitId);

			var commit = client.Execute<Commit>(request);
			return commit.Data;
		}

		#endregion

		#region Branches queries

		/// <summary>
		/// https://www.visualstudio.com/en-us/docs/integrate/api/git/refs#just-branches
		/// </summary>
		public static Collection<Branch> GetBranches(Guid repositoryId)
		{
			//Just branches
			// Sample request
			// GET https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/refs/heads?includeStatuses=true&api-version=1.0
			var client = CreateClient();
			var request = CreateGetRequest(GitAddressBuilder.RepositoriesResource + "/{repositoryId}/refs/heads");
			request.AddUrlSegment("repositoryId", repositoryId.ToString());

			return client.Execute(request).ToCollection<Branch>();
		}

		#endregion

		#region Work items queries

		public static WorkItem GetWorkItemInfo(uint workItemId)
		{
			// https://tfs.gecko.no:8088/tfs/DefaultCollection/_apis/wit/workitems/73207
			var client = CreateClient();
			var request = CreateGetRequest(GitAddressBuilder.WorkItemsResource + "/{workItemId}");
			request.AddUrlSegment("workItemId", workItemId.ToString());

			var response = client.Execute<WorkItem>(request);
			return response.Data;
		}

		public static IEnumerable<CommitInfo> GetWorkItems(IEnumerable<CommitInfo> commits)
		{
			// https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/wit/workitems?ids=297,299,300&api-version=1.0
			var client = CreateClient();
			var request = CreateGetRequest(GitAddressBuilder.WorkItemsResource);

			var commitsList = commits.ToList();
			request.AddQueryParameter("ids", string.Join(",", commitsList.Where(commit => commit.AssociatedWorkItem != null).Select(commit => commit.AssociatedWorkItem.Id)));
			
			var collection = client.Execute(request).ToCollection<WorkItem>();
			foreach (var workItem in collection.Value)
			{
				var commitMatched = commitsList.FindAll(cmt => cmt.AssociatedWorkItem != null && cmt.AssociatedWorkItem.Id == workItem.Id);
				foreach (var commit in commitMatched)
				{
					commit.AssociatedWorkItem = workItem;
				}
			}

			return commitsList;
		}

		#endregion

		#region Custom queries

		public static IEnumerable<CommitInfo> GetCommits(Guid repositoryId, string sourceBranch, IEnumerable<string> excludedBranches)
		{
			var excludedCommitIds = new List<string>();
			foreach (var excludedBranch in excludedBranches)
			{
				excludedCommitIds.AddRange(GetCommits(repositoryId, excludedBranch).Value.Select(i => i.CommitId));
			}

			var sourceBranchCommits = GetCommits(repositoryId, sourceBranch)
				.Value.Where(commit => !excludedCommitIds.Contains(commit.CommitId))
				.Select(commit => new CommitInfo(commit) {RepositoryId = repositoryId}).ToList();

			return sourceBranchCommits;
		}

		#endregion

		#endregion

		#region Private methods

		private static IRestClient CreateClient()
		{
			var restClient = new RestClient(GitAddressBuilder.BaseAddress);
			var networkCredentials = GitAddressBuilder.Credential;
			restClient.Authenticator = new HttpBasicAuthenticator(networkCredentials.UserName, networkCredentials.Password);
			return restClient;
		}

		private static IRestRequest CreateGetRequest(string requestUrl)
		{
			var request = new RestRequest(requestUrl, Method.GET);
			request.AddQueryParameter("api-version", "3.0");
			if (MaxRecordCount > 0)
			{
				request.AddQueryParameter("$top", MaxRecordCount.ToString());
			}
			//request.Credentials = GitAddressBuilder.Credential;
			
			return request;
		}

		#endregion
	}
}
