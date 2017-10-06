using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor.FilterHandling
{
	public partial class ucDuplicatePbiCheckBoxFilter : UserControl, IFilterCommitInfoControl
	{
		public ucDuplicatePbiCheckBoxFilter()
		{
			InitializeComponent();
		}

		private DuplicatePbiDetectorStrategy _filterStrategy = null;

		public void ResetFilter()
		{
			checkBox1.Checked = false;
			_filterStrategy = null;
		}

		public void InitFilter()
		{
			_filterStrategy = new DuplicatePbiDetectorStrategy();
		}

		public bool IsItemVisible(CommitInfo commitInfo)
		{
			return !checkBox1.Checked || _filterStrategy.IsVisible(commitInfo);
		}
	}
}
