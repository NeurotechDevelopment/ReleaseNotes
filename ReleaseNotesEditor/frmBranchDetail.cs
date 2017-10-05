using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitTfsRestServiceProxy;

namespace ReleaseNotesEditor
{
	public partial class frmBranchDetail : Form
	{
		public frmBranchDetail()
		{
			InitializeComponent();
		}

		private Guid repositoryId;
		private string branchName;

		public frmBranchDetail(Guid repositoryId, string branchName) : this()
		{
			this.repositoryId = repositoryId;
			this.branchName = branchName;
		}

		private void frmBranchDetail_Load(object sender, EventArgs e)
		{
			//GitProjectRepository.GetBranchInfo(repositoryId);
		}
	}
}
