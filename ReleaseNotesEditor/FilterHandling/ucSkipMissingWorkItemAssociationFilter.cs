using System.Windows.Forms;
using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor.FilterHandling
{
	public partial class ucSkipMissingWorkItemAssociationFilter : UserControl, IFilterCommitInfoControl
	{
		public ucSkipMissingWorkItemAssociationFilter()
		{
			InitializeComponent();
		}

		public void ResetFilter()
		{
			checkBox1.Checked = false;
		}

		public void InitFilter()
		{
		}

		public bool IsItemVisible(CommitInfo commitInfo)
		{
			return !checkBox1.Checked || (commitInfo.AssociatedWorkItem != null && commitInfo.AssociatedWorkItem.Id > 0);
		}
	}
}
