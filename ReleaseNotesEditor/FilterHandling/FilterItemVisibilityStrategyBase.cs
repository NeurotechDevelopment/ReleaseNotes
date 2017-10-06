using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor.FilterHandling
{
	public abstract class FilterItemVisibilityStrategyBase
	{
		public abstract bool IsVisible(CommitInfo commitInfo);
	}
}