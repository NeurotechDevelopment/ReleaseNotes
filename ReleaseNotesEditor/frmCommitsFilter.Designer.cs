using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor
{
	partial class frmCommitsFilter
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dgvCommits = new System.Windows.Forms.DataGridView();
			this.commitInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnFilterApply = new System.Windows.Forms.Button();
			this.filterAreaPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.CommitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CommiterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AuthorDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CommiterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPbiTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WorkItemLink = new System.Windows.Forms.DataGridViewLinkColumn();
			this.colAreaPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCommits)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commitInfoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCommits
			// 
			this.dgvCommits.AllowUserToAddRows = false;
			this.dgvCommits.AllowUserToDeleteRows = false;
			this.dgvCommits.AutoGenerateColumns = false;
			this.dgvCommits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCommits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommitId,
            this.dataGridViewTextBoxColumn9,
            this.AuthorName,
            this.CommiterName,
            this.AuthorDate,
            this.CommiterDate,
            this.colPbiTitle,
            this.WorkItemLink,
            this.colAreaPath,
            this.dataGridViewCheckBoxColumn1});
			this.dgvCommits.DataSource = this.commitInfoBindingSource;
			this.dgvCommits.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCommits.GridColor = System.Drawing.SystemColors.Control;
			this.dgvCommits.Location = new System.Drawing.Point(0, 0);
			this.dgvCommits.Name = "dgvCommits";
			this.dgvCommits.ReadOnly = true;
			this.dgvCommits.RowHeadersVisible = false;
			this.dgvCommits.RowTemplate.Height = 24;
			this.dgvCommits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCommits.Size = new System.Drawing.Size(1034, 431);
			this.dgvCommits.TabIndex = 1;
			this.dgvCommits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommits_CellContentClick);
			// 
			// commitInfoBindingSource
			// 
			this.commitInfoBindingSource.DataSource = typeof(CommonDataAndUtilities.DataClassAdapters.CommitInfo);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(4, 567);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(2, 2);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgvCommits);
			this.splitContainer1.Size = new System.Drawing.Size(1034, 559);
			this.splitContainer1.SplitterDistance = 124;
			this.splitContainer1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnFilterApply);
			this.groupBox1.Controls.Add(this.filterAreaPath);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1034, 124);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filter";
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Location = new System.Drawing.Point(950, 93);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnFilterApply
			// 
			this.btnFilterApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFilterApply.Location = new System.Drawing.Point(874, 93);
			this.btnFilterApply.Name = "btnFilterApply";
			this.btnFilterApply.Size = new System.Drawing.Size(75, 23);
			this.btnFilterApply.TabIndex = 3;
			this.btnFilterApply.Text = "Apply";
			this.btnFilterApply.UseVisualStyleBackColor = true;
			this.btnFilterApply.Click += new System.EventHandler(this.btnFilterApply_Click);
			// 
			// filterAreaPath
			// 
			this.filterAreaPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filterAreaPath.Location = new System.Drawing.Point(138, 25);
			this.filterAreaPath.Name = "filterAreaPath";
			this.filterAreaPath.Size = new System.Drawing.Size(887, 22);
			this.filterAreaPath.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Project area path:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(8, 96);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(211, 16);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Load associated commits with PBI";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoadCommitsWithWorkItems_LinkClicked);
			// 
			// CommitId
			// 
			this.CommitId.DataPropertyName = "CommitId";
			this.CommitId.HeaderText = "CommitId";
			this.CommitId.Name = "CommitId";
			this.CommitId.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn9.HeaderText = "Comment";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// AuthorName
			// 
			this.AuthorName.DataPropertyName = "AuthorName";
			this.AuthorName.HeaderText = "Author";
			this.AuthorName.Name = "AuthorName";
			this.AuthorName.ReadOnly = true;
			// 
			// CommiterName
			// 
			this.CommiterName.DataPropertyName = "CommiterName";
			this.CommiterName.HeaderText = "Commiter";
			this.CommiterName.Name = "CommiterName";
			this.CommiterName.ReadOnly = true;
			// 
			// AuthorDate
			// 
			this.AuthorDate.DataPropertyName = "AuthorDate";
			this.AuthorDate.HeaderText = "Author Date";
			this.AuthorDate.Name = "AuthorDate";
			this.AuthorDate.ReadOnly = true;
			// 
			// CommiterDate
			// 
			this.CommiterDate.DataPropertyName = "CommiterDate";
			this.CommiterDate.HeaderText = "Commiter Date";
			this.CommiterDate.Name = "CommiterDate";
			this.CommiterDate.ReadOnly = true;
			// 
			// colPbiTitle
			// 
			this.colPbiTitle.HeaderText = "Pbi title";
			this.colPbiTitle.Name = "colPbiTitle";
			this.colPbiTitle.ReadOnly = true;
			// 
			// WorkItemLink
			// 
			this.WorkItemLink.HeaderText = "Work item";
			this.WorkItemLink.Name = "WorkItemLink";
			this.WorkItemLink.ReadOnly = true;
			this.WorkItemLink.Text = "Work item";
			this.WorkItemLink.UseColumnTextForLinkValue = true;
			// 
			// colAreaPath
			// 
			this.colAreaPath.HeaderText = "Area Path";
			this.colAreaPath.Name = "colAreaPath";
			this.colAreaPath.ReadOnly = true;
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
			this.dataGridViewCheckBoxColumn1.HeaderText = "IsSelected";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.ReadOnly = true;
			// 
			// frmCommitsFilter
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1039, 600);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.button1);
			this.Name = "frmCommitsFilter";
			this.Text = "Select commits to show";
			this.Load += new System.EventHandler(this.frmCommitsFilter_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCommits)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commitInfoBindingSource)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource commitInfoBindingSource;
		private System.Windows.Forms.DataGridView dgvCommits;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button btnFilterApply;
		private System.Windows.Forms.TextBox filterAreaPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.DataGridViewTextBoxColumn CommitId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CommiterName;
		private System.Windows.Forms.DataGridViewTextBoxColumn AuthorDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn CommiterDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPbiTitle;
		private System.Windows.Forms.DataGridViewLinkColumn WorkItemLink;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAreaPath;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
	}
}