using System.Collections.Generic;
using CommonDataAndUtilities;
using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor.FilterHandling
{
	public class DuplicatePbiDetectorStrategy : FilterItemVisibilityStrategyBase
	{
		private List<uint> _workItemIdList = new List<uint>();

		public override bool IsVisible(CommitInfo commitInfo)
		{
			uint? workItemId = PbiNumberParser.TryGetPbiNumberFromComments(commitInfo.Comment);
			if (!workItemId.HasValue)
			{
				return true;
			}

			if (_workItemIdList.Contains(workItemId.Value))
			{
				return false;
			}

			_workItemIdList.Add(workItemId.Value);
			return true;
		}
	}
}