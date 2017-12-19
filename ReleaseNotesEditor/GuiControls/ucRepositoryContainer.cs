using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CommonDataAndUtilities.GitRestApiDataClasses;
using ReleaseNotesEditor.Commands;

namespace ReleaseNotesEditor.GuiControls
{
	public partial class ucRepositoryContainer : UserControl
	{
		private readonly List<Repository> _dataSource = new List<Repository>();

		public IEnumerable<Repository> DataSource
		{
			get
			{
				return _dataSource; 
			}
			set
			{
				_dataSource.Clear();
				flowLayoutPanel1.Controls.Clear();
				if (value != null)
				{
					flowLayoutPanel1.SuspendLayout();
					foreach (var repository in value)
					{
						_dataSource.Add(repository);
						flowLayoutPanel1.Controls.Add(new ucRepository { DataSource = repository, Width = flowLayoutPanel1.ClientSize.Width, ShowBranchesWindow = new ShowSelectBranchesCommand(repository)});
					}
					ApplyRepositoryFilter();
					flowLayoutPanel1.ResumeLayout(performLayout: true);
				}
			}
		}

		public ucRepositoryContainer()
		{
			InitializeComponent();
		}

		private void ApplyRepositoryFilter()
		{
			if (_dataSource.Count > 0)
			{
				flowLayoutPanel1.SuspendLayout();
				var nonMatchingControls =
					flowLayoutPanel1.Controls.Cast<ucRepository>()
						.Where(uc => !uc.DataSource.Name.ToUpperInvariant().StartsWith(txtRepositoryNameFilter.Text.ToUpperInvariant()))
						.ToArray();
				foreach (var uc in flowLayoutPanel1.Controls.Cast<ucRepository>())
				{
					uc.Visible = !nonMatchingControls.Contains(uc);
				}
				
				flowLayoutPanel1.ResumeLayout(performLayout: true);
			}
		}

		private void txtRepositoryNameFilter_TextChanged(object sender, System.EventArgs e)
		{
			ApplyRepositoryFilter();
		}
	}
}
