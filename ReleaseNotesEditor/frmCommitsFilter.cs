using System.Collections.Generic;
using System.Windows.Forms;
using ReleaseNotesEditor.DataClasses;
using ReleaseNotesEditor.HelperClasses;

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

		private void dgvCommits_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || e.ColumnIndex == -1)
			{
				return;
			}

			if (dgvCommits.Columns[e.ColumnIndex].Name == WorkItemLink.Name)
			{
				var commitInfo = dgvCommits.Rows[e.RowIndex].DataBoundItem as CommitInfo;
				var workItemId = PbiNumberParser.TryGetPbiNumberFromComments(commitInfo.Comment);
				if (workItemId.HasValue)
				{
					new frmWorkItemViewer(workItemId.Value).Show();
				}
			}
		}
	}
}
