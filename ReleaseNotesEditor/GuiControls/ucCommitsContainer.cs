using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor.GuiControls
{
	public partial class ucCommitsContainer : UserControl
	{
		private readonly List<CommitInfo> dataSource = new List<CommitInfo>();

		public event EventHandler CommitIncludeChanged;

		public IEnumerable<CommitInfo> DataSource
		{
			get { return dataSource; }
			set
			{
				dataSource.Clear();
				flowLayoutPanel1.Controls.Clear();

				if (value != null)
				{
					flowLayoutPanel1.SuspendLayout();
					foreach (var commitInfo in value)
					{
						dataSource.Add(commitInfo);

						var commitEditorControl = new ucCommit {DataSource = commitInfo, Width = flowLayoutPanel1.ClientSize.Width};
						commitEditorControl.CommitCheckedChanged += (s, e) => CommitIncludeChanged?.Invoke(s, e);
						flowLayoutPanel1.Controls.Add(commitEditorControl);
					}
					flowLayoutPanel1.ResumeLayout(performLayout: true);
				}
			}
		}

		public IEnumerable<string> SelectedComments
		{
			get
			{
				foreach (var uc in flowLayoutPanel1.Controls.Cast<ucCommit>().Where(i => i.IsIncludedForExport))
				{
					yield return uc.CommitComment;
				}
			}
		}

		public int IncludedCommits => flowLayoutPanel1.Controls.Cast<ucCommit>().Count(i => i.IsIncludedForExport);

		private int? visibleCommits = null;
		public int TotalCommits => visibleCommits.HasValue ? visibleCommits.Value : dataSource.Count;

		public int ExcludedCommits => TotalCommits - IncludedCommits;

		public ucCommitsContainer()
		{
			InitializeComponent();
		}


		public IEnumerable<CommitInfo> GetEditedCommits()
		{
			return flowLayoutPanel1.Controls.Cast<ucCommit>().Select(uc => uc.DataSource);
		}

		public void SetVisibleCommitControls(IEnumerable<CommitInfo> visibleItems)
		{
			var commitIds = visibleItems.Select(i => i.CommitId).ToList();
			visibleCommits = 0;
			flowLayoutPanel1.SuspendLayout();
			foreach (var ucCommit in flowLayoutPanel1.Controls.Cast<ucCommit>())
			{
				ucCommit.Visible = commitIds.Contains(ucCommit.DataSource.CommitId);
				visibleCommits += Convert.ToInt32(ucCommit.Visible);
			}
			flowLayoutPanel1.ResumeLayout(true);
		}

		public void ShowAll()
		{
			visibleCommits = 0;
			foreach (var ucCommit in flowLayoutPanel1.Controls.Cast<ucCommit>())
			{
				ucCommit.Visible = true;
				visibleCommits++;
			}
		}

		private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
		{
			flowLayoutPanel1.SuspendLayout();
			foreach (Control ctrl in flowLayoutPanel1.Controls)
			{
				ctrl.Width = flowLayoutPanel1.ClientSize.Width;
			}
			flowLayoutPanel1.ResumeLayout();
		}
	}
}
