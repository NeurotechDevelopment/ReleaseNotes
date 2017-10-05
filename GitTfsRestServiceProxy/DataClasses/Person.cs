using System;

namespace GitTfsRestServiceProxy.DataClasses
{
	[Serializable]
	public class Person
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public DateTime Date { get; set; }
	}
}