using System;
using System.Linq;
using System.Windows.Forms;
using CommonDataAndUtilities.DataClassAdapters;
using CommonDataAndUtilities.GitRestApiDataClasses;
using GitTfsRestServiceProxy;

namespace ReleaseNotesEditor
{
	public partial class frmSelectBranches : Form
	{
		private Guid? repositoryId;

		public frmSelectBranches()
		{
			InitializeComponent();
		}

		public frmSelectBranches(Guid repositoryId) : this()
		{
			this.repositoryId = repositoryId;
		}

		private void frmBranches_Load(object sender, EventArgs e)
		{
			LoadBranches();
		}

		private void btnApplyBranchNameFilter_Click(object sender, EventArgs e)
		{
			LoadBranches();
		}

		private void LoadBranches()
		{
			if (!DesignMode)
			{
				var branches = GitProjectRepository.GetBranches(repositoryId.Value).Value;
				bsBranchComboBox.DataSource = branches.Where(br => !br.Name.Contains(textBox1.Text));
				bsBranchExcluded.DataSource = branches;
			}
		}

		private void OpenExportCommitsEditor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var sourceBranch = (bsBranchComboBox.Current as Branch).Name.Replace("refs/heads/", string.Empty);
			var excludedBranches = listBox1.SelectedItems.Cast<Branch>().Select(i => i.Name.Replace("refs/heads/", string.Empty)).ToList();

			var commitsDiff = GitProjectRepository.GetCommits(repositoryId.Value, sourceBranch, excludedBranches);
			if (chkOpenPrefilterWindow.Checked)
			{
				using (var dlg = new frmCommitsFilter(commitsDiff))
				{
					if (dlg.ShowDialog() == DialogResult.OK)
					{
						commitsDiff = dlg.SelectedCommits.ToList();
					}
				}
			}

			new frmCommitsEditor(new ReleaseCommits
			{
				RepositoryId = repositoryId.Value,
				Commits = commitsDiff.ToList(),
				ExcludedBranches = excludedBranches,
				SourceBranch = sourceBranch
			}).Show();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < listBox1.Items.Count; i++)
			{
				listBox1.SetSelected(i, checkBox1.Checked);
			}

			checkBox1.Text = checkBox1.Checked ? "Deselect all" : "Select all";
		}
	}
}
