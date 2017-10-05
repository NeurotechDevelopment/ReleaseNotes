using System;

namespace CommonDataAndUtilities.GitRestApiDataClasses
{
	[Serializable]
	public class Repository
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public Uri Url { get; set; }

		public Project Project { get; set; }

		public string DefaultBranch { get; set; }

		public Uri RemoteUrl { get; set; }
	}
}