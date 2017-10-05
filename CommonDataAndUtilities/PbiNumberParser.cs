using System.Text.RegularExpressions;

namespace CommonDataAndUtilities
{
	public static class PbiNumberParser
	{
		const string WorkItemPattern = "((?<=PBI[' ']*#?)[0-9]{3,5})|((?<=Bug[' ']*#?)[0-9]{3,5})|((?<=Product backlog item[' ']*#?)[0-9]{3,5})";

		private static readonly Regex PbiNumberRegex = new Regex(WorkItemPattern, RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

		public static uint? TryGetPbiNumberFromComments(string commitComment)
		{
			var match = PbiNumberRegex.Match(commitComment);
			return match.Success ? (uint?)uint.Parse(match.Value) : null;
		}
	}
}
