using System;

namespace CommonDataAndUtilities.GitRestApiDataClasses
{
	[Serializable]
	public class Project
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public Uri Url { get; set; }

		public string State { get; set; }

		public int Revision { get; set; }
	}
}