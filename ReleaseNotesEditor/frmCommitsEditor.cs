using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using CommonDataAndUtilities.DataClassAdapters;
using GitTfsRestServiceProxy;

namespace ReleaseNotesEditor
{
	public partial class frmCommitsEditor : Form
	{
		private Guid _repositoryId;
		private string _sourceBranchName;
		private IEnumerable<string> _excludeBranchesNames;
		private uint _maxCommits;

		public frmCommitsEditor()
		{
			InitializeComponent();
		}

		public frmCommitsEditor(Guid repositoryId, string sourceBranchName, IEnumerable<string> excludeBranchesNames,
			uint maxCommits = 10000) : this()
		{
			SetMembers(repositoryId, sourceBranchName, excludeBranchesNames, maxCommits);
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
			_repositoryId = repositoryId;
			_sourceBranchName = sourceBranchId;
			_excludeBranchesNames = excludeBranchesObjectId;
			_maxCommits = maxCommits;
			UpdateCommitsStats();
		}

		private void LoadCommitsFromGit()
		{
			var excludedCommitIds = new List<string>();
			foreach (var excludedBranch in _excludeBranchesNames)
			{
				excludedCommitIds.AddRange(GitProjectRepository.GetCommits(_repositoryId, _maxCommits, excludedBranch).Value.Select(i => i.CommitId));
			}

			var sourceBranchCommits =
				GitProjectRepository.GetCommits(_repositoryId, _maxCommits, _sourceBranchName)
					.Value.Where(commit => !excludedCommitIds.Contains(commit.CommitId))
					.Select(commit => new CommitInfo(commit) { RepositoryId = _repositoryId }).ToList();

			ucCommitsContainer1.DataSource = sourceBranchCommits;
			ucCommitsContainer1.CommitIncludeChanged += UcCommitsContainer1_CommitIncludeChanged;
			UpdateCommitsStats();
		}

		private void LoadCommitsFromDataset(ReleaseCommits dataSource)
		{
			ucCommitsContainer1.DataSource = dataSource.Commits;
			lbTotalCommits.Text = dataSource.Commits.Count.ToString();
			ucCommitsContainer1.CommitIncludeChanged += UcCommitsContainer1_CommitIncludeChanged;
			UpdateCommitsStats();
		}

		private void UpdateCommitsStats()
		{
			lbSourceBranch.Text = _sourceBranchName.Replace("r_", string.Empty);
			lbExludedBranches.Text = string.Join(",", _excludeBranchesNames.Select(branchName => branchName.Replace("r_", string.Empty)));
			lbTotalCommits.Text = ucCommitsContainer1.TotalCommits.ToString();
			lbExcludedCommit.Text = ucCommitsContainer1.ExcludedCommits.ToString();
			lbIncludedCommits.Text = ucCommitsContainer1.IncludedCommits.ToString();
		}

		private void UcCommitsContainer1_CommitIncludeChanged(object sender, EventArgs e)
		{
			UpdateCommitsStats();
		}

		private void frmCommitsEditor_Load(object sender, EventArgs e)
		{
		}

		private void ExportToReleaseNotesFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using (var saveFileDialog = new SaveFileDialog())
			{
				var releaseBranch = _sourceBranchName.Replace("r_", string.Empty);
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
				RepositoryId = _repositoryId,
				SourceBranch = _sourceBranchName,
				ExcludedBranches = _excludeBranchesNames.ToList(),
				Commits = ucCommitsContainer1.GetEditedCommits().ToList()
			};

			using (var saveFileDialog = new SaveFileDialog())
			{
				var releaseBranch = _sourceBranchName.Replace("r_", string.Empty);
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
					UpdateCommitsStats();
				}
			}
		}
	}
}
