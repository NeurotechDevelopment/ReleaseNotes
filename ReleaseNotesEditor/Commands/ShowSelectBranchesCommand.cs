using CommonDataAndUtilities.GitRestApiDataClasses;

namespace ReleaseNotesEditor.Commands
{
	public class ShowSelectBranchesCommand : OpenWindowCommand
	{
		private readonly Repository _repository;

		public ShowSelectBranchesCommand(Repository repository)
		{
			_repository = repository;
		}

		public override void Execute()
		{
			new frmSelectBranches(_repository).ShowDialog();
		}
	}
}
