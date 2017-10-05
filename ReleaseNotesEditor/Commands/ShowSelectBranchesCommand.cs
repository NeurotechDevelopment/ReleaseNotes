using System;

namespace ReleaseNotesEditor.Commands
{
	public class ShowSelectBranchesCommand : OpenWindowCommand
	{
		private readonly Guid repositoryId;

		public ShowSelectBranchesCommand(Guid repositoryId)
		{
			this.repositoryId = repositoryId;
		}

		public override void Execute()
		{
			new frmSelectBranches(repositoryId).ShowDialog();
		}
	}
}
