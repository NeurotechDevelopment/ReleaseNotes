using System;
using System.Configuration;
using System.Net;

namespace GitTfsRestServiceProxy
{
	public static class GitAddressBuilder
	{
		private static string ApiEndpoint => ConfigurationManager.AppSettings["GitApiEndpointAddress"];

		internal static Uri BaseAddress => new Uri(ConfigurationManager.AppSettings["GitTfsBaseAddress"]);

		internal static string RepositoriesResource => new Uri(ApiEndpoint + "git/repositories", UriKind.Relative).ToString();

		internal static string WorkItemsResource => new Uri(ApiEndpoint + "wit/workitems/", UriKind.Relative).ToString();

		internal static NetworkCredential Credential
			=>
				new NetworkCredential(ConfigurationManager.AppSettings["GitUsername"],
					ConfigurationManager.AppSettings["GitPassword"]);

		public static Uri GetWorkItemOnBoardAddress(uint pbiNumber)
		{
			return new Uri(BaseAddress, ConfigurationManager.AppSettings["WorkItemOnBoardAddress"].Replace("#pbiNumber", pbiNumber.ToString()));
		}
	}
}
