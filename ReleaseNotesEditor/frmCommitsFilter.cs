using System.Collections.Generic;
using System.Windows.Forms;
using ReleaseNotesEditor.DataClassExtensions;

namespace ReleaseNotesEditor
{
	public partial class frmCommitsFilter : Form
	{
		public IEnumerable<CommitInfo> SelectedCommits
		{
			get
			{
				foreach (DataGridViewRow selectedRow in dgvCommits.SelectedRows)
				{
					yield return selectedRow.DataBoundItem as CommitInfo;
				}
			}
		}

		public frmCommitsFilter(IEnumerable<CommitInfo> commits)
		{
			InitializeComponent();
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			commitInfoBindingSource.DataSource = commits;
		}

		private void frmCommitsFilter_Load(object sender, System.EventArgs e)
		{
			foreach (DataGridViewRow selectedRow in dgvCommits.Rows)
			{
				selectedRow.Selected = ((CommitInfo) selectedRow.DataBoundItem).IsSelected;
			}
		}
	}
}
