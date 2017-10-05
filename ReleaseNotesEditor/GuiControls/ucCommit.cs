using System;
using System.Windows.Forms;
using GitTfsRestServiceProxy;
using CommonDataAndUtilities;
using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor.GuiControls
{
	public partial class ucCommit : UserControl
	{
		private bool isLoaded = false;
		private bool disableCheckChangedEvent = false;
		private CommitInfo dataSource;

		public bool IsIncludedForExport => checkBox1.Checked;

		public event EventHandler CommitCheckedChanged;

		public string CommitComment
		{
			get { return txtCommitMessage.Text; }
		}

		public CommitInfo DataSource
		{
			get
			{
				dataSource.Comment = txtCommitMessage.Text;
				return dataSource;
			}
			set
			{
				dataSource = value;
				if (dataSource != null)
				{
					txtCommitId.Text = dataSource.CommitId;
					txtCommitMessage.Text = dataSource.Comment;
					txtAuthorDate.Text = $"{dataSource.AuthorName} at {dataSource.AuthorDate}";
					txtCommited.Text = $"{dataSource.CommiterName} at {dataSource.CommiterDate}";

					if (dataSource.IsSelected)
					{
						disableCheckChangedEvent = true;
						checkBox1.Checked = true;
						disableCheckChangedEvent = false;
					}
				}
			}
		}

		public ucCommit()
		{
			InitializeComponent();
		}

		

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (disableCheckChangedEvent)
			{
				return;
			}

			txtCommitMessage.Enabled = checkBox1.Checked;

			if (checkBox1.Checked && !isLoaded)
			{
				txtCommitMessage.Text = GitProjectRepository.GetCommit(dataSource.RepositoryId, dataSource.CommitId).Comment;
			}
			dataSource.IsSelected = checkBox1.Checked;
			CommitCheckedChanged?.Invoke(this, e);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			uint? workItem = PbiNumberParser.TryGetPbiNumberFromComments(txtCommitMessage.Text);

			if (workItem.HasValue)
			{
				new frmWorkItemViewer(workItem.Value).Show();
			}
			else
			{
				MessageBox.Show("Couldn't parse workitem.");
			}
		}
	}
}
