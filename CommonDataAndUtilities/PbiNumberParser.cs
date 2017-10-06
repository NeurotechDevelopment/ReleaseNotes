using System.Text.RegularExpressions;

namespace CommonDataAndUtilities
{
	public static class PbiNumberParser
	{
		const string WorkItemNumberPattern = "((?<=PBI[' ']*#?)[0-9]{3,5})|((?<=Bug[' ']*#?)[0-9]{3,5})|((?<=Product backlog item[' ']*#?)[0-9]{3,5})";
		const string WorkItemTokenPattern = "(PBI[' ']*#?[0-9]{3,5})|(Bug[' ']*#?[0-9]{3,5})";

		private static readonly Regex PbiNumberRegex = new Regex(WorkItemNumberPattern, RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
		private static readonly Regex PbiTokenRegex = new Regex(WorkItemTokenPattern, RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

		public static uint? TryGetPbiNumber(string commitComment)
		{
			var match = PbiNumberRegex.Match(commitComment);
			return match.Success ? (uint?)uint.Parse(match.Value) : null;
		}

		public static string TryGetPbiToken(string commitComment)
		{
			var match = PbiTokenRegex.Match(commitComment);
			return match.Success ? match.Value : string.Empty;
		}
	}
}
