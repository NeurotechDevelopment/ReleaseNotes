using System.Collections.Generic;

namespace CommonDataAndUtilities.GitRestApiDataClasses
{
	public class Collection<T>
	{
		public IEnumerable<T> Value { get; set; }

		public int Count { get; set; }
	}
}