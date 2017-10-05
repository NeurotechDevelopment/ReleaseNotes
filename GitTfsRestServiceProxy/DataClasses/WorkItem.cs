using System;
using System.Collections.Generic;

namespace GitTfsRestServiceProxy.DataClasses
{
	[Serializable]
	public class WorkItem
	{
		/*
		"System.AreaPath": "Projects\\NCore Team",
		"System.TeamProject": "Projects",
		"System.IterationPath": "Projects\\NCore Team\\2017\\Work done 17.09.15 - 17.09.28",
		"System.WorkItemType": "Bug",
		"System.Title": "K-Kode Update scripts needs to be fixed. Also add fix to 6.4.0 version scripts",
		*/
		public int Id { get; set; }

		public Dictionary<string, string> Fields { get; set; }
	}
}
