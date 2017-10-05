using System;
using System.Linq;
using System.Windows.Forms;
using GitTfsRestServiceProxy;

namespace ReleaseNotesEditor
{
	public partial class frmRepositorySelector : Form
	{
		public frmRepositorySelector()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (!DesignMode)
			{
				ucRepositoryContainer1.DataSource = GitProjectRepository.GetRepositories().Value.Where(r => !r.Name.StartsWith("NuGet", StringComparison.InvariantCultureIgnoreCase)).ToArray();
				//ucRepositoryContainer1.DataSource = GitProjectRepository.GetRepositories().Value;
				/*
				var r = GitProjectRepository.GetRepositories();
	
				Guid repositoryId = r.Value.First(item => item.Name == "EphorteWeb").Id;
				GitProjectRepository.GetCommits(repositoryId);
				GitProjectRepository.GetBranches(repositoryId);
				*/
			}
		}
	}
}
