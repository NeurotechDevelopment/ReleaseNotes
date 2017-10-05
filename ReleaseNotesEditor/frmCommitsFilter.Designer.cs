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
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.commitInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvCommits)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commitInfoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCommits
			// 
			this.dgvCommits.AllowUserToAddRows = false;
			this.dgvCommits.AllowUserToDeleteRows = false;
			this.dgvCommits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCommits.AutoGenerateColumns = false;
			this.dgvCommits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCommits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1});
			this.dgvCommits.DataSource = this.commitInfoBindingSource;
			this.dgvCommits.GridColor = System.Drawing.SystemColors.Control;
			this.dgvCommits.Location = new System.Drawing.Point(1, 1);
			this.dgvCommits.Name = "dgvCommits";
			this.dgvCommits.ReadOnly = true;
			this.dgvCommits.RowHeadersVisible = false;
			this.dgvCommits.RowTemplate.Height = 24;
			this.dgvCommits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCommits.Size = new System.Drawing.Size(1007, 315);
			this.dgvCommits.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(1, 328);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn9.HeaderText = "Comment";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
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
			this.commitInfoBindingSource.DataSource = typeof(ReleaseNotesEditor.DataClassExtensions.CommitInfo);
			// 
			// frmCommitsFilter
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1010, 363);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvCommits);
			this.Name = "frmCommitsFilter";
			this.Text = "Select commits to show";
			this.Load += new System.EventHandler(this.frmCommitsFilter_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCommits)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commitInfoBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource commitInfoBindingSource;
		private System.Windows.Forms.DataGridView dgvCommits;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.Button button1;
	}
}