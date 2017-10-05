using System;
using System.Configuration;
using System.Net;

namespace GitTfsRestServiceProxy
{
	internal static class GitAddressBuilder
	{

		internal static Uri BaseAddress => new Uri(ConfigurationManager.AppSettings["GitApiBaseAddress"]);

		internal static string RepositoriesResource => "tfs/DefaultCollection/_apis/git/repositories";

		internal static NetworkCredential Credential
			=>
				new NetworkCredential(ConfigurationManager.AppSettings["GitUsername"],
					ConfigurationManager.AppSettings["GitPassword"]);
	}
}
