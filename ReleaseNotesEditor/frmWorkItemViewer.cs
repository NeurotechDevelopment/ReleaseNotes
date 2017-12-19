using System;
using System.Windows.Forms;
using GitTfsRestServiceProxy;

namespace ReleaseNotesEditor
{
	public partial class frmWorkItemViewer : Form
	{
		private uint pbiNumber;

		public frmWorkItemViewer(uint pbiNumber)
		{
			InitializeComponent();
			this.pbiNumber = pbiNumber;
		}

		private void frmInternetExplorer_Load(object sender, EventArgs e)
		{
			webBrowser1.Navigate(GitAddressBuilder.GetWorkItemOnBoardAddress(pbiNumber));
		}
	}
}
