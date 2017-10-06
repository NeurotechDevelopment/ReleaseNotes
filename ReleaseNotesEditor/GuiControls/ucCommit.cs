using System;
using System.Drawing;
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
					txtCommitMessage.Text = dataSource.Comment;
					txtAuthorDate.Text = $"{dataSource.AuthorName} at {dataSource.AuthorDate}";
					txtCommited.Text = $"{dataSource.CommiterName} at {dataSource.CommiterDate}";

					if (dataSource.AssociatedWorkItem != null)
					{
						txtWorkItemTitle.Text = dataSource.AssociatedWorkItem.Title;
						txtAcceptanceCriteria.Text = dataSource.AssociatedWorkItem.Resolution;
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

		#region Helper methods

		private void SetCommitMessagePreservingPbi(string commitComment)
		{
			txtCommitMessage.Text = PbiTokenParser.TryTrimStartAndInsertSharp(commitComment);
		}

		private string GetWorkTitleWithPbi(string text)
		{
			string pbiToken = PbiTokenParser.TryGetPbiToken(txtCommitMessage.Text);
			if (!string.IsNullOrWhiteSpace(pbiToken))
			{
				text = $"{pbiToken} {txtWorkItemTitle.Text}";
			}

			return text;
		}

		#endregion

		#region Event handlers

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
				var comment = GitProjectRepository.GetCommit(dataSource.RepositoryId, dataSource.CommitId).Comment;
				SetCommitMessagePreservingPbi(comment);
			}
			dataSource.IsSelected = checkBox1.Checked;
			CommitCheckedChanged?.Invoke(this, e);
		}

		private void ViewWorkItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			uint? workItem = PbiTokenParser.TryGetPbiNumber(txtCommitMessage.Text);

			if (workItem.HasValue)
			{
				new frmWorkItemViewer(workItem.Value).Show();
			}
			else
			{
				MessageBox.Show("Couldn't parse workitem.");
			}
		}

		private void ReplaceCommitMessageWithWorkItemTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtWorkItemTitle.Text))
			{
				txtCommitMessage.Text = GetWorkTitleWithPbi(txtWorkItemTitle.Text);
			}
		}

		private void AppendAcceptanceCriteria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtAcceptanceCriteria.Text))
			{
				string commitText = txtCommitMessage.Text;
				if (!commitText.EndsWith("."))
				{
					commitText += ".";
				}

				commitText += " ";
				commitText += txtAcceptanceCriteria.Text;
				txtCommitMessage.Text = commitText;
			}
		}

		private void ReplaceAndAppend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ReplaceCommitMessageWithWorkItemTitle_LinkClicked(sender, e);
			AppendAcceptanceCriteria_LinkClicked(sender, e);
		}

		#endregion
	}
}
