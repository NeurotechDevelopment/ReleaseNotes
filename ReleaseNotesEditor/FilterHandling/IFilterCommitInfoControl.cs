using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor.FilterHandling
{
	interface IFilterCommitInfoControl
	{
		/// <summary>
		/// Resets filter control to initial value and initializes filter condition for IsVisible method.
		/// </summary>
		void ResetFilter();

		/// <summary>
		/// Resets filtering strategy.
		/// </summary>
		void InitFilter();

		/// <summary>
		/// Can be used in loops after <see cref="InitFilter"/> method is called.
		/// </summary>
		/// <param name="commitInfo">Data item to check, if it passes filter.</param>
		bool IsItemVisible(CommitInfo commitInfo);
	}
}
