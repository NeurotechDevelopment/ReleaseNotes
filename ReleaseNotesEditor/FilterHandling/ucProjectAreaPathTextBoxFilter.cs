using System.Windows.Forms;
using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor.FilterHandling
{
	public partial class ucProjectAreaPathTextBoxFilter : UserControl, IFilterCommitInfoControl
	{
		public ucProjectAreaPathTextBoxFilter()
		{
			InitializeComponent();
		}

		private AssociatedWorkItemFilterStrategy _filterStrategy = null;

		public void ResetFilter()
		{
			textBox1.Text = string.Empty;
			_filterStrategy = null;
		}

		public void InitFilter()
		{
			_filterStrategy = new AssociatedWorkItemFilterStrategy(textBox1.Text);
		}

		public bool IsItemVisible(CommitInfo commitInfo)
		{
			return string.IsNullOrWhiteSpace(textBox1.Text) || _filterStrategy.IsVisible(commitInfo);
		}
	}
}
