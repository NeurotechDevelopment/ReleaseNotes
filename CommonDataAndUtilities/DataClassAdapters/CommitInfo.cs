using System;
using CommonDataAndUtilities.GitRestApiDataClasses;

namespace CommonDataAndUtilities.DataClassAdapters
{
	[Serializable]
	public class CommitInfo
	{
		public Guid RepositoryId { get; set; }

		public string CommitId { get; set; }

		public string AuthorName { get; set; }

		public string AuthorEmail { get; set; }

		public DateTime AuthorDate { get; set; }

		public string CommiterName { get; set; }

		public string CommiterEmail { get; set; }

		public DateTime CommiterDate { get; set; }

		public string Comment { get; set; }

		public bool IsSelected { get; set; }

		public WorkItem AssociatedWorkItem { get; set; }

		public CommitInfo()
		{
		}

		public CommitInfo(Commit commit)
		{
			CommitId = commit.CommitId;
			AuthorName = commit.Author.Name;
			AuthorEmail = commit.Author.Email;
			AuthorDate = commit.Author.Date;
			CommiterName = commit.Committer.Name;
			CommiterEmail = commit.Committer.Email;
			CommiterDate = commit.Committer.Date;
			Comment = commit.Comment;
		}
	}
}