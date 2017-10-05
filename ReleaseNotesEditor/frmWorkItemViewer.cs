using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			webBrowser1.Navigate(new Uri($"https://tfs.gecko.no:8088/tfs/DefaultCollection/Projects/_workitems?id={pbiNumber}&_a=edit"));
		}
	}
}
