using System;

namespace GitTfsRestServiceProxy.DataClasses
{
	[Serializable]
	public class ObjectCreator
	{
		public string Id { get; set; }

		public string DisplayName { get; set; }

		public string UniqueName { get; set; }

		public Uri Url { get; set; }

		public Uri ImageUrl { get; set; }
	}
}