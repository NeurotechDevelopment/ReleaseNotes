using System;
using System.Linq;
using System.Windows.Forms;
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

		private void button1_Click(object sender, EventArgs e)
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

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var sourceBranch = bsBranchComboBox.Current as Branch;
			var excludedBranches = listBox1.SelectedItems.Cast<Branch>();
			new frmCommitsEditor(repositoryId.Value, sourceBranch.Name.Replace("refs/heads/",string.Empty), excludedBranches.Select(i => i.Name.Replace("refs/heads/", string.Empty))).Show();
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
