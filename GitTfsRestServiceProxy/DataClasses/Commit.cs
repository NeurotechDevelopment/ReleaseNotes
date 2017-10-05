using System;

namespace GitTfsRestServiceProxy.DataClasses
{
	[Serializable]
	public class Commit
	{
		public string CommitId { get; set; }

		public Person Author { get; set; }

		public Person Committer { get; set; }

		public string Comment { get; set; }
	}
}