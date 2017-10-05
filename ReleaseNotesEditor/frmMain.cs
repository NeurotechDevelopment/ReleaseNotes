using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReleaseNotesEditor.DataClassExtensions;

namespace ReleaseNotesEditor
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void openRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmRepositorySelector { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
		}

		private void openCommitEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReleaseCommits dataSource = null;
			using (var openFileDialog = new OpenFileDialog())
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					var serializer = new DataContractSerializer(typeof(ReleaseCommits));
					using (var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
					{
						dataSource = (ReleaseCommits)serializer.ReadObject(fileStream);
					}
				}
			}

			if (dataSource != null)
			{
				new frmCommitsEditor(dataSource) { MdiParent = this, WindowState = FormWindowState.Maximized }.Show();
			}
		}
	}
}
