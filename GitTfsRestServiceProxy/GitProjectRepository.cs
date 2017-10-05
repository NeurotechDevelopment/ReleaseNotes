using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RestSharp;

namespace GitTfsRestServiceProxy
{
	public static class GitProjectRepository
	{
		#region Public methods

		public static Collection<Repository> GetRepositories()
		{
			var client = CreateClient();
			var request = CreateGetRequest(GitAddressBuilder.RepositoriesResource);

			var response = client.Execute(request);
			return GetCollection<Repository>(response);
		}

		/// <summary>
		/// https://www.visualstudio.com/en-us/docs/integrate/api/git/commits
		/// </summary>
		public static Collection<Commit> GetCommits(Guid repositoryId, uint maxCommites = 100, string branchName = null)
		{
			// https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/git/repositories/278d5cd2-584d-4b63-824a-2ba458937249/commits?api-version=1.0
			var client = CreateClient();
			var request = CreateGetRequest(GitAddressBuilder.RepositoriesResource + "/{repositoryId}/commits");
			request.AddUrlSegment("repositoryId", repositoryId.ToString());
			request.AddQueryParameter("$top", maxCommites.ToString());
			if (!string.IsNullOrWhiteSpace(branchName))
			{
				request.AddQueryParameter("branch", branchName);
			}

			var response = client.Execute(request);
			var commits = GetCollection<Commit>(response);
			return commits;
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
			// request.AddQueryParameter("includeStatuses", "true");

			var response = client.Execute(request);
			var branches = GetCollection<Branch>(response);
			return branches;
		}

		#endregion

		#region Private methods

		private static Collection<T> GetCollection<T>(IRestResponse response)
		{
			JsonSerializer serializer = new JsonSerializer();
			StringReader stringReader = new StringReader(response.Content);
			JsonTextReader reader = new JsonTextReader(stringReader);
			return serializer.Deserialize<Collection<T>>(reader);
		}

		private static IRestClient CreateClient()
		{
			return new RestClient(GitAddressBuilder.BaseAddress);
		}

		private static IRestRequest CreateGetRequest(string requestUrl)
		{
			var request = new RestRequest(requestUrl, Method.GET);
			request.AddQueryParameter("api-version", "3.0");
			request.Credentials = GitAddressBuilder.Credential;

			return request;
		}

		#endregion
	}
}
