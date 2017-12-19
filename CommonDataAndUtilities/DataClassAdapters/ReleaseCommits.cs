using System;
using System.Collections.Generic;

namespace CommonDataAndUtilities.DataClassAdapters
{
	[Serializable]
	public class ReleaseCommits
	{
		public Guid RepositoryId { get; set; }

		public string RepositoryName { get; set; }

		public string SourceBranch { get; set; }

		public List<string> ExcludedBranches { get; set; }

		public List<CommitInfo> Commits { get; set; }
	}
}
