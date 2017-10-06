using System;
using System.Drawing;
using System.Text.RegularExpressions;
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

					if (dataSource.AssociatedWorkItem != null)
					{
						txtWorkItemTitle.Text = dataSource.AssociatedWorkItem.Title;
					}

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

		private void LoadFullCommitInfo_CheckedChanged(object sender, EventArgs e)
		{
			BackColor = checkBox1.Checked ? Color.Goldenrod : DefaultBackColor;
			if (disableCheckChangedEvent)
			{
				return;
			}

			txtCommitMessage.Enabled = checkBox1.Checked;

			if (checkBox1.Checked && !isLoaded)
			{
				// Remove all garbage text preceding PBI word
				var formattedComment = GitProjectRepository.GetCommit(dataSource.RepositoryId, dataSource.CommitId).Comment;
				var match = Regex.Match(formattedComment, "PBI|Bug", RegexOptions.IgnoreCase);
				if (match.Success)
				{
					formattedComment = formattedComment.Substring(match.Index);
				}

				var unsharpedPbi = Regex.Match(formattedComment, "(?<=PBI[' ']*)[0-9]{3,5}|(?<=Bug[' ']*)[0-9]{3,5}", RegexOptions.IgnoreCase);
				if (unsharpedPbi.Success)
				{
					formattedComment = formattedComment.Replace(unsharpedPbi.Value, "#" + unsharpedPbi.Value);
				}

				txtCommitMessage.Text = formattedComment;
			}
			dataSource.IsSelected = checkBox1.Checked;
			CommitCheckedChanged?.Invoke(this, e);
		}

		private void ViewWorkItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			uint? workItem = PbiNumberParser.TryGetPbiNumber(txtCommitMessage.Text);

			if (workItem.HasValue)
			{
				new frmWorkItemViewer(workItem.Value).Show();
			}
			else
			{
				MessageBox.Show("Couldn't parse workitem.");
			}
		}

		private void btnReplaceCommitMessageWithWotkItemTitle_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtWorkItemTitle.Text))
			{
				string pbiToken = PbiNumberParser.TryGetPbiToken(txtCommitMessage.Text);
				if (!string.IsNullOrWhiteSpace(pbiToken))
				{
					txtCommitMessage.Text = $"{pbiToken} {txtWorkItemTitle.Text}";
				}
			}
		}
	}
}
