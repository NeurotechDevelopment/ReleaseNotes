using System;
using System.Collections.Generic;

namespace ReleaseNotesEditor.Commands
{
	public class ShowCommitsCommand : OpenWindowCommand
	{
		private Guid repositoryId;
		private string sourceBranchId;
		private IEnumerable<string> excludeBranchesObjectId;
		private uint maxCommits;

		public ShowCommitsCommand(Guid repositoryId, string sourceBranchId, IEnumerable<string> excludeBranchesObjectId, uint maxCommits = 1000)
		{
			this.repositoryId = repositoryId;
			this.sourceBranchId = sourceBranchId;
			this.excludeBranchesObjectId = excludeBranchesObjectId;
			this.maxCommits = maxCommits;
		}

		public override void Execute()
		{
			new frmCommitsEditor(repositoryId, sourceBranchId, excludeBranchesObjectId, maxCommits).ShowDialog();
		}
	}
}
