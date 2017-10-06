using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor.FilterHandling
{
	#region Row visibility strategies

	public class AlwaysVisibleStrategy : FilterItemVisibilityStrategyBase
	{
		public override bool IsVisible(CommitInfo commitInfo)
		{
			return true;
		}
	}

	#endregion
}
