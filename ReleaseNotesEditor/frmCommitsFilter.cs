﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CommonDataAndUtilities;
using CommonDataAndUtilities.DataClassAdapters;
using CommonDataAndUtilities.GitRestApiDataClasses;
using GitTfsRestServiceProxy;
using ReleaseNotesEditor.FilterHandling;

namespace ReleaseNotesEditor
{
	public partial class frmCommitsFilter : Form
	{
		private IEnumerable<CommitInfo> _dataSource;

		public IEnumerable<CommitInfo> SelectedCommits
		{
			get
			{
				foreach (DataGridViewRow selectedRow in dgvCommits.SelectedRows)
				{
					yield return selectedRow.DataBoundItem as CommitInfo;
				}
			}
		}

		public frmCommitsFilter(IEnumerable<CommitInfo> commits)
		{
			InitializeComponent();
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			commitInfoBindingSource.DataSource = _dataSource = commits;
		}

		private void frmCommitsFilter_Load(object sender, System.EventArgs e)
		{
			foreach (DataGridViewRow selectedRow in dgvCommits.Rows)
			{
				selectedRow.Selected = ((CommitInfo) selectedRow.DataBoundItem).IsSelected;
			}

			lbShownCommits.Text = _dataSource.Count().ToString();
		}

		private void OpenWorkItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || e.ColumnIndex == -1)
			{
				return;
			}

			if (dgvCommits.Columns[e.ColumnIndex].Name == WorkItemLink.Name)
			{
				var commitInfo = dgvCommits.Rows[e.RowIndex].DataBoundItem as CommitInfo;
				var workItemId = PbiNumberParser.TryGetPbiNumberFromComments(commitInfo.Comment);
				if (workItemId.HasValue)
				{
					new frmWorkItemViewer(workItemId.Value).Show();
				}
			}
		}

		private void LoadAssoicatedWorkItems()
		{
			foreach (var item in _dataSource)
			{
				var pbiNumber = PbiNumberParser.TryGetPbiNumberFromComments(item.Comment);
				if (pbiNumber.HasValue)
				{
					item.AssociatedWorkItem = new WorkItem { Id = (int)pbiNumber.Value };
				}
			}

			_dataSource = GitProjectRepository.GetWorkItems(_dataSource);

			commitInfoBindingSource.ResetBindings(false);

			foreach (DataGridViewRow row in dgvCommits.Rows)
			{
				var commitInfo = row.DataBoundItem as CommitInfo;
				if (commitInfo.AssociatedWorkItem != null)
				{
					dgvCommits[colAreaPath.Name, row.Index].Value = commitInfo.AssociatedWorkItem.AreaPath;
					dgvCommits[colPbiTitle.Name, row.Index].Value = commitInfo.AssociatedWorkItem.Title;
				}
			}
		}

		#region Grid row visibility/filtering

		private void SetVisibleRows(List<IFilterCommitInfoControl> visibilityStrategies)
		{
			int visibleCount = 0;
			CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCommits.DataSource];
			currencyManager1.SuspendBinding();

			foreach (DataGridViewRow row in dgvCommits.Rows)
			{
				row.Visible = visibilityStrategies.All(x => x.IsItemVisible(row.DataBoundItem as CommitInfo));
				visibleCount += Convert.ToInt32(row.Visible);
			}

			currencyManager1.ResumeBinding();

			lbShownCommits.Text = visibleCount.ToString();
		}

		private void btnFilterApply_Click(object sender, EventArgs e)
		{
			// Get filter controls
			List<IFilterCommitInfoControl> filtersList = new List<IFilterCommitInfoControl>();
			foreach (var control in groupBox1.Controls)
			{
				var filterCommitControl = control as IFilterCommitInfoControl;
				if (filterCommitControl != null)
				{
					filterCommitControl.InitFilter();
					filtersList.Add(filterCommitControl);
				}
			}

			SetVisibleRows(filtersList);
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			// Get filter controls
			List<IFilterCommitInfoControl> filtersList = new List<IFilterCommitInfoControl>();
			foreach (var control in groupBox1.Controls)
			{
				var filterCommitControl = control as IFilterCommitInfoControl;
				if (filterCommitControl != null)
				{
					filterCommitControl.ResetFilter();
					filtersList.Add(filterCommitControl);
				}
			}

			SetVisibleRows(filtersList);
		}


		#endregion

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LoadAssoicatedWorkItems();
		}
	}
}
