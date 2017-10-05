using System.Collections.Generic;

namespace GitTfsRestServiceProxy.DataClasses
{
	public class Collection<T>
	{
		public IEnumerable<T> Value { get; set; }

		public int Count { get; set; }
	}
}