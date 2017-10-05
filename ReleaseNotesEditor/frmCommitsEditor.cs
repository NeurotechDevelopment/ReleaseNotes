using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using GitTfsRestServiceProxy;
using ReleaseNotesEditor.DataClassExtensions;

namespace ReleaseNotesEditor
{
	public partial class frmCommitsEditor : Form
	{
		private Guid repositoryId;
		private string sourceBranchId;
		private IEnumerable<string> excludeBranchesObjectId;
		private uint maxCommits;

		public frmCommitsEditor()
		{
			InitializeComponent();
		}

		public frmCommitsEditor(Guid repositoryId, string sourceBranchId, IEnumerable<string> excludeBranchesObjectId,
			uint maxCommits = 10000) : this()
		{
			SetMembers(repositoryId, sourceBranchId, excludeBranchesObjectId, maxCommits);
			LoadCommitsFromGit();
		}

		public frmCommitsEditor(ReleaseCommits dataSource):this()
		{
			SetMembers(dataSource.RepositoryId, dataSource.SourceBranch, dataSource.ExcludedBranches);
			LoadCommitsFromDataset(dataSource);
		}

		private void SetMembers(Guid repositoryId, string sourceBranchId, IEnumerable<string> excludeBranchesObjectId,
			uint maxCommits = 1000)
		{
			this.repositoryId = repositoryId;
			this.sourceBranchId = sourceBranchId;
			this.excludeBranchesObjectId = excludeBranchesObjectId;
			this.maxCommits = maxCommits;
			lbSourceBranch.Text = sourceBranchId.Replace("r_", string.Empty);
			lbExludedBranches.Text = string.Join(",", excludeBranchesObjectId);
		}

		private void LoadCommitsFromGit()
		{
			var excludedCommitIds = new List<string>();
			foreach (var excludedBranch in excludeBranchesObjectId)
			{
				excludedCommitIds.AddRange(GitProjectRepository.GetCommits(repositoryId, maxCommits, excludedBranch).Value.Select(i => i.CommitId));
			}

			var sourceBranchCommits =
				GitProjectRepository.GetCommits(repositoryId, maxCommits, sourceBranchId)
					.Value.Where(commit => !excludedCommitIds.Contains(commit.CommitId))
					.Select(commit => new CommitInfo(commit) { RepositoryId = repositoryId });

			ucCommitsContainer1.DataSource = sourceBranchCommits;
			lbTotalCommits.Text = sourceBranchCommits.Count().ToString();
			ucCommitsContainer1.CommitIncludeChanged += UcCommitsContainer1_CommitIncludeChanged;
			UpdateIncludedCommitsCount();
		}

		private void LoadCommitsFromDataset(ReleaseCommits dataSource)
		{
			ucCommitsContainer1.DataSource = dataSource.Commits;
			lbTotalCommits.Text = dataSource.Commits.Count.ToString();
			ucCommitsContainer1.CommitIncludeChanged += UcCommitsContainer1_CommitIncludeChanged;
			UpdateIncludedCommitsCount();
		}

		private void UpdateIncludedCommitsCount()
		{
			lbTotalCommits.Text = ucCommitsContainer1.TotalCommits.ToString();
			lbExcludedCommit.Text = ucCommitsContainer1.ExcludedCommits.ToString();
			lbIncludedCommits.Text = ucCommitsContainer1.IncludedCommits.ToString();
		}

		private void UcCommitsContainer1_CommitIncludeChanged(object sender, EventArgs e)
		{
			UpdateIncludedCommitsCount();
		}

		private void frmCommitsEditor_Load(object sender, EventArgs e)
		{
		}

		private void ExportToReleaseNotesFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using (var saveFileDialog = new SaveFileDialog())
			{
				var releaseBranch = sourceBranchId.Replace("r_", string.Empty);
				saveFileDialog.FileName = $"ReleaseNotes_{releaseBranch}.md";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					var sb = new StringBuilder($"# EphorteWeb `{releaseBranch}` release notes");
					sb.AppendLine();
					sb.AppendLine("`TODO: Release date`");
					sb.AppendLine();
					sb.AppendLine("## Features and bug fixes");
					foreach (var commitMessage in ucCommitsContainer1.SelectedComments)
					{
						sb.AppendFormat($"- {commitMessage}");
						sb.AppendLine();
					}

					File.WriteAllText(saveFileDialog.FileName, sb.ToString());
				}
			}
		}

		private void SaveProgress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var dataSource = new ReleaseCommits
			{
				RepositoryId = repositoryId,
				SourceBranch = sourceBranchId,
				ExcludedBranches = excludeBranchesObjectId.ToList(),
				Commits = ucCommitsContainer1.GetEditedCommits().ToList()
			};

			using (var saveFileDialog = new SaveFileDialog())
			{
				var releaseBranch = sourceBranchId.Replace("r_", string.Empty);
				saveFileDialog.FileName = $"ReleaseNotes_{releaseBranch}.dat";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					var serializer = new DataContractSerializer(typeof(ReleaseCommits));
					using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
					{
						serializer.WriteObject(fileStream, dataSource);
					}
				}
			}
		}

		private void FilterCommits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using (var dlgFilterCommits = new frmCommitsFilter(ucCommitsContainer1.DataSource))
			{
				if (dlgFilterCommits.ShowDialog() == DialogResult.OK)
				{
					ucCommitsContainer1.SetVisibleCommitControls(dlgFilterCommits.SelectedCommits);
					UpdateIncludedCommitsCount();
				}
			}
		}
	}
}
