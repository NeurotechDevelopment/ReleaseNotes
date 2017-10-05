using System.Windows.Forms;
using CommonDataAndUtilities.GitRestApiDataClasses;
using ReleaseNotesEditor.Commands;

namespace ReleaseNotesEditor.GuiControls
{
	public partial class ucRepository : UserControl
	{
		private Repository _dataSource;
		
		public Repository DataSource
		{
			get
			{
				return _dataSource;
			}
			set
			{
				_dataSource = value;
				if (_dataSource != null)
				{
					txtName.Text = _dataSource.Name;
				}
			}
		}

		public OpenWindowCommand ShowBranchesWindow { get; set; }

		public ucRepository()
		{
			InitializeComponent();
		}

		private void ucRepository_Load(object sender, System.EventArgs e)
		{
			txtName.BorderStyle = DesignMode ? BorderStyle.Fixed3D : BorderStyle.None;
		}

		private void OnShowBranchesWindowClick(object sender, System.EventArgs e)
		{
			ShowBranchesWindow?.Execute();
		}
	}
}
