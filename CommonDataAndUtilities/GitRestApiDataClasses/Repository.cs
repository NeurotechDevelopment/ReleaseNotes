using System;

namespace CommonDataAndUtilities.GitRestApiDataClasses
{
	[Serializable]
	public class Repository
	{
		public Guid Id { get; set; }

		public string Name { get; set; }
	}
}