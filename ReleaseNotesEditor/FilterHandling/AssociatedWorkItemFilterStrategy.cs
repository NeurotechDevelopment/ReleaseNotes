using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor.FilterHandling
{
	public class AssociatedWorkItemFilterStrategy : FilterItemVisibilityStrategyBase
	{
		private readonly string _filterText;

		public AssociatedWorkItemFilterStrategy(string filterText)
		{
			_filterText = filterText.ToUpperInvariant();
		}

		public override bool IsVisible(CommitInfo commitInfo)
		{
			return commitInfo.AssociatedWorkItem == null ||
			       commitInfo.AssociatedWorkItem.AreaPath.ToUpperInvariant().StartsWith(_filterText);
		}
	}
}