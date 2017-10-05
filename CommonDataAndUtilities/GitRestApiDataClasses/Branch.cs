using System;

namespace CommonDataAndUtilities.GitRestApiDataClasses
{
	[Serializable]
	public class Branch
	{
		public string ObjectId { get; set; }

		public string Name { get; set; }

		public Uri Url { get; set; }

		public DateTime CreationDate { get; set; }

		public Uri TargetUrl { get; set; }

		public ObjectCreator CreatedBy { get; set; }
	}
}