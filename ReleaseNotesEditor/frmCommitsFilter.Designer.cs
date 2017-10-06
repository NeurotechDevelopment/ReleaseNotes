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
			this.colPbiTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WorkItemLink = new System.Windows.Forms.DataGridViewLinkColumn();
			this.colAreaPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnFilterApply = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.CommitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CommiterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AuthorDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CommiterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.commitInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.ucDuplicatePbiCheckBoxFilter1 = new ReleaseNotesEditor.FilterHandling.ucDuplicatePbiCheckBoxFilter();
			this.ucProjectAreaPathTextBoxFilter1 = new ReleaseNotesEditor.FilterHandling.ucProjectAreaPathTextBoxFilter();
			this.label2 = new System.Windows.Forms.Label();
			this.lbShownCommits = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCommits)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.commitInfoBindingSource)).BeginInit();
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
            this.dataGridViewCheckBoxColumn1,
            this.colPbiTitle,
            this.WorkItemLink,
            this.colAreaPath});
			this.dgvCommits.DataSource = this.commitInfoBindingSource;
			this.dgvCommits.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCommits.GridColor = System.Drawing.SystemColors.Control;
			this.dgvCommits.Location = new System.Drawing.Point(0, 0);
			this.dgvCommits.Name = "dgvCommits";
			this.dgvCommits.ReadOnly = true;
			this.dgvCommits.RowHeadersVisible = false;
			this.dgvCommits.RowTemplate.Height = 24;
			this.dgvCommits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCommits.Size = new System.Drawing.Size(1166, 338);
			this.dgvCommits.TabIndex = 1;
			this.dgvCommits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OpenWorkItem_CellContentClick);
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
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(11, 624);
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
			this.splitContainer1.Location = new System.Drawing.Point(4, 45);
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
			this.splitContainer1.Size = new System.Drawing.Size(1166, 502);
			this.splitContainer1.SplitterDistance = 160;
			this.splitContainer1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ucDuplicatePbiCheckBoxFilter1);
			this.groupBox1.Controls.Add(this.ucProjectAreaPathTextBoxFilter1);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnFilterApply);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1166, 160);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filter";
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Location = new System.Drawing.Point(1088, 125);
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
			this.btnFilterApply.Location = new System.Drawing.Point(1007, 125);
			this.btnFilterApply.Name = "btnFilterApply";
			this.btnFilterApply.Size = new System.Drawing.Size(75, 23);
			this.btnFilterApply.TabIndex = 3;
			this.btnFilterApply.Text = "Apply";
			this.btnFilterApply.UseVisualStyleBackColor = true;
			this.btnFilterApply.Click += new System.EventHandler(this.btnFilterApply_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Project area path:";
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
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn9.HeaderText = "Comment";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Width = 110;
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
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsSelected";
			this.dataGridViewCheckBoxColumn1.HeaderText = "IsSelected";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.ReadOnly = true;
			// 
			// commitInfoBindingSource
			// 
			this.commitInfoBindingSource.DataSource = typeof(CommonDataAndUtilities.DataClassAdapters.CommitInfo);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(12, 9);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(105, 16);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Load work items";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// ucDuplicatePbiCheckBoxFilter1
			// 
			this.ucDuplicatePbiCheckBoxFilter1.Location = new System.Drawing.Point(22, 91);
			this.ucDuplicatePbiCheckBoxFilter1.Name = "ucDuplicatePbiCheckBoxFilter1";
			this.ucDuplicatePbiCheckBoxFilter1.Size = new System.Drawing.Size(185, 21);
			this.ucDuplicatePbiCheckBoxFilter1.TabIndex = 5;
			// 
			// ucProjectAreaPathTextBoxFilter1
			// 
			this.ucProjectAreaPathTextBoxFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ucProjectAreaPathTextBoxFilter1.Location = new System.Drawing.Point(138, 52);
			this.ucProjectAreaPathTextBoxFilter1.Name = "ucProjectAreaPathTextBoxFilter1";
			this.ucProjectAreaPathTextBoxFilter1.Size = new System.Drawing.Size(1025, 24);
			this.ucProjectAreaPathTextBoxFilter1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 562);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Commits count:";
			// 
			// lbShownCommits
			// 
			this.lbShownCommits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbShownCommits.AutoSize = true;
			this.lbShownCommits.Location = new System.Drawing.Point(111, 562);
			this.lbShownCommits.Name = "lbShownCommits";
			this.lbShownCommits.Size = new System.Drawing.Size(15, 16);
			this.lbShownCommits.TabIndex = 8;
			this.lbShownCommits.Text = "0";
			// 
			// frmCommitsFilter
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1171, 659);
			this.Controls.Add(this.lbShownCommits);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.button1);
			this.Name = "frmCommitsFilter";
			this.Text = "Select commits to show";
			this.Load += new System.EventHandler(this.frmCommitsFilter_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCommits)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.commitInfoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource commitInfoBindingSource;
		private System.Windows.Forms.DataGridView dgvCommits;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnFilterApply;
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
		private FilterHandling.ucDuplicatePbiCheckBoxFilter ucDuplicatePbiCheckBoxFilter1;
		private FilterHandling.ucProjectAreaPathTextBoxFilter ucProjectAreaPathTextBoxFilter1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbShownCommits;
	}
}