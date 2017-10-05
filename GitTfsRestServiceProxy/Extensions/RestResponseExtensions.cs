using System.IO;
using CommonDataAndUtilities.GitRestApiDataClasses;
using Newtonsoft.Json;
using RestSharp;

namespace GitTfsRestServiceProxy.Extensions
{
	public static class RestResponseExtensions
	{
		public static Collection<T> ToCollection<T>(this IRestResponse response)
		{
			JsonSerializer serializer = new JsonSerializer();
			StringReader stringReader = new StringReader(response.Content);
			JsonTextReader reader = new JsonTextReader(stringReader);
			return serializer.Deserialize<Collection<T>>(reader);
		}
	}
}
