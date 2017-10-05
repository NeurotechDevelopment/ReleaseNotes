using CommonDataAndUtilities.DataClassAdapters;

namespace ReleaseNotesEditor
{
	partial class frmCommitsEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommitsEditor));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbExcludedCommit = new System.Windows.Forms.Label();
			this.lbSourceBranch = new System.Windows.Forms.Label();
			this.lbIncludedCommits = new System.Windows.Forms.Label();
			this.lbExludedBranches = new System.Windows.Forms.Label();
			this.lbTotalCommits = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.ucCommitsContainer1 = new ReleaseNotesEditor.GuiControls.ucCommitsContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.linkLabel2);
			this.splitContainer1.Panel1.Controls.Add(this.linkLabel3);
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.ucCommitsContainer1);
			this.splitContainer1.Size = new System.Drawing.Size(937, 422);
			this.splitContainer1.SplitterDistance = 112;
			this.splitContainer1.TabIndex = 1;
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(320, 9);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(147, 16);
			this.linkLabel2.TabIndex = 10;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Select commits to show";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FilterCommits_LinkClicked);
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Location = new System.Drawing.Point(13, 9);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(97, 16);
			this.linkLabel3.TabIndex = 9;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Save progress";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveProgress_LinkClicked);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lbExcludedCommit);
			this.groupBox1.Controls.Add(this.lbSourceBranch);
			this.groupBox1.Controls.Add(this.lbIncludedCommits);
			this.groupBox1.Controls.Add(this.lbExludedBranches);
			this.groupBox1.Controls.Add(this.lbTotalCommits);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(3, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(931, 82);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(428, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 16);
			this.label6.TabIndex = 4;
			this.label6.Text = "Excluded commits:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "List of commits in branch:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(312, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Excluded commits from branch(es):";
			// 
			// lbExcludedCommit
			// 
			this.lbExcludedCommit.AutoSize = true;
			this.lbExcludedCommit.Location = new System.Drawing.Point(554, 50);
			this.lbExcludedCommit.Name = "lbExcludedCommit";
			this.lbExcludedCommit.Size = new System.Drawing.Size(15, 16);
			this.lbExcludedCommit.TabIndex = 5;
			this.lbExcludedCommit.Text = "0";
			// 
			// lbSourceBranch
			// 
			this.lbSourceBranch.AutoSize = true;
			this.lbSourceBranch.Location = new System.Drawing.Point(175, 22);
			this.lbSourceBranch.Name = "lbSourceBranch";
			this.lbSourceBranch.Size = new System.Drawing.Size(95, 16);
			this.lbSourceBranch.TabIndex = 2;
			this.lbSourceBranch.Text = "Source branch";
			// 
			// lbIncludedCommits
			// 
			this.lbIncludedCommits.AutoSize = true;
			this.lbIncludedCommits.Location = new System.Drawing.Point(371, 50);
			this.lbIncludedCommits.Name = "lbIncludedCommits";
			this.lbIncludedCommits.Size = new System.Drawing.Size(15, 16);
			this.lbIncludedCommits.TabIndex = 5;
			this.lbIncludedCommits.Text = "0";
			// 
			// lbExludedBranches
			// 
			this.lbExludedBranches.AutoSize = true;
			this.lbExludedBranches.Location = new System.Drawing.Point(537, 22);
			this.lbExludedBranches.Name = "lbExludedBranches";
			this.lbExludedBranches.Size = new System.Drawing.Size(116, 16);
			this.lbExludedBranches.TabIndex = 3;
			this.lbExludedBranches.Text = "Exluded branches";
			// 
			// lbTotalCommits
			// 
			this.lbTotalCommits.AutoSize = true;
			this.lbTotalCommits.Location = new System.Drawing.Point(173, 50);
			this.lbTotalCommits.Name = "lbTotalCommits";
			this.lbTotalCommits.Size = new System.Drawing.Size(15, 16);
			this.lbTotalCommits.TabIndex = 5;
			this.lbTotalCommits.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Total number of commits:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(250, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Included commits:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(121, 9);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(171, 16);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Export to ReleaseNotes file";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExportToReleaseNotesFile_LinkClicked);
			// 
			// ucCommitsContainer1
			// 
			this.ucCommitsContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ucCommitsContainer1.DataSource = ((System.Collections.Generic.IEnumerable<CommitInfo>)(resources.GetObject("ucCommitsContainer1.DataSource")));
			this.ucCommitsContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucCommitsContainer1.Location = new System.Drawing.Point(0, 0);
			this.ucCommitsContainer1.Name = "ucCommitsContainer1";
			this.ucCommitsContainer1.Size = new System.Drawing.Size(937, 306);
			this.ucCommitsContainer1.TabIndex = 0;
			// 
			// frmCommitsEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(937, 422);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmCommitsEditor";
			this.Text = "Commits export";
			this.Load += new System.EventHandler(this.frmCommitsEditor_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GuiControls.ucCommitsContainer ucCommitsContainer1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label lbTotalCommits;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbExludedBranches;
		private System.Windows.Forms.Label lbSourceBranch;
		private System.Windows.Forms.Label lbExcludedCommit;
		private System.Windows.Forms.Label lbIncludedCommits;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel linkLabel2;
	}
}