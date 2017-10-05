using System;
using System.Collections.Generic;

namespace GitTfsRestServiceProxy
{
	public class Collection<T>
	{
		public IEnumerable<T> Value { get; set; }

		public int Count { get; set; }
	}

	[Serializable]
	public class Repository
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public Uri Url { get; set; }

		public Project Project { get; set; }

		public string DefaultBranch { get; set; }

		public Uri RemoteUrl { get; set; }
	}

	[Serializable]
	public class Project
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public Uri Url { get; set; }

		public string State { get; set; }

		public int Revision { get; set; }
	}

	[Serializable]
	public class Person
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public DateTime Date { get; set; }
	}

	[Serializable]
	public class Commit
	{
		public string CommitId { get; set; }

		public Person Author { get; set; }

		public Person Committer { get; set; }

		public string Comment { get; set; }
	}

	[Serializable]
	public class Branch
	{
		public string ObjectId { get; set; }

		public string Name { get; set; }

		public Uri Url { get; set; }

		public IEnumerable<ObjectStatus> Statuses { get; set; }

		public DateTime CreationDate { get; set; }

		public Uri TargetUrl { get; set; }

		public ObjectCreator CreatedBy { get; set; }
	}

	[Serializable]
	public class ObjectCreator
	{
		public string Id { get; set; }

		public string DisplayName { get; set; }

		public string UniqueName { get; set; }

		public Uri Url { get; set; }

		public Uri ImageUrl { get; set; }
	}

	[Serializable]
	public class ObjectStatus
	{
		public string State { get; set; }

		public string Description { get; set; }

		public Context Context { get; set; }
	}

	[Serializable]
	public class Context
	{
		public string Name { get; set; }

		public string Genre { get; set; }
	}
}
