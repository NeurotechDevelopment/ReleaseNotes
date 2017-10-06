namespace ReleaseNotesEditor.GuiControls
{
	partial class ucCommit
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.txtCommitMessage = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAuthorDate = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCommited = new System.Windows.Forms.TextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label5 = new System.Windows.Forms.Label();
			this.txtWorkItemTitle = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAcceptanceCriteria = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Commit comment:";
			// 
			// txtCommitMessage
			// 
			this.txtCommitMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCommitMessage.Location = new System.Drawing.Point(7, 25);
			this.txtCommitMessage.Multiline = true;
			this.txtCommitMessage.Name = "txtCommitMessage";
			this.txtCommitMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCommitMessage.Size = new System.Drawing.Size(953, 149);
			this.txtCommitMessage.TabIndex = 3;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(7, 4);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(70, 20);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Include";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.LoadFullCommitInfo_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Authored:";
			// 
			// txtAuthorDate
			// 
			this.txtAuthorDate.Location = new System.Drawing.Point(91, 40);
			this.txtAuthorDate.Name = "txtAuthorDate";
			this.txtAuthorDate.ReadOnly = true;
			this.txtAuthorDate.Size = new System.Drawing.Size(311, 22);
			this.txtAuthorDate.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(429, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Commited:";
			// 
			// txtCommited
			// 
			this.txtCommited.Location = new System.Drawing.Point(507, 41);
			this.txtCommited.Name = "txtCommited";
			this.txtCommited.ReadOnly = true;
			this.txtCommited.Size = new System.Drawing.Size(336, 22);
			this.txtCommited.TabIndex = 6;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(864, 130);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(100, 16);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Open work item";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewWorkItem_LinkClicked);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Title:";
			// 
			// txtWorkItemTitle
			// 
			this.txtWorkItemTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtWorkItemTitle.Location = new System.Drawing.Point(49, 25);
			this.txtWorkItemTitle.Name = "txtWorkItemTitle";
			this.txtWorkItemTitle.Size = new System.Drawing.Size(911, 22);
			this.txtWorkItemTitle.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 65);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Resolution:";
			// 
			// txtAcceptanceCriteria
			// 
			this.txtAcceptanceCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAcceptanceCriteria.Location = new System.Drawing.Point(9, 84);
			this.txtAcceptanceCriteria.Multiline = true;
			this.txtAcceptanceCriteria.Name = "txtAcceptanceCriteria";
			this.txtAcceptanceCriteria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAcceptanceCriteria.Size = new System.Drawing.Size(951, 40);
			this.txtAcceptanceCriteria.TabIndex = 12;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(6, 80);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.txtCommitMessage);
			this.splitContainer1.Size = new System.Drawing.Size(966, 343);
			this.splitContainer1.SplitterDistance = 162;
			this.splitContainer1.TabIndex = 13;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.linkLabel4);
			this.groupBox1.Controls.Add(this.linkLabel3);
			this.groupBox1.Controls.Add(this.linkLabel2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Controls.Add(this.txtAcceptanceCriteria);
			this.groupBox1.Controls.Add(this.txtWorkItemTitle);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(966, 162);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Work item details:";
			// 
			// linkLabel4
			// 
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.Location = new System.Drawing.Point(329, 130);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(136, 16);
			this.linkLabel4.TabIndex = 15;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "Replace and append";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReplaceAndAppend_LinkClicked);
			// 
			// linkLabel3
			// 
			this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Location = new System.Drawing.Point(131, 130);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(160, 16);
			this.linkLabel3.TabIndex = 14;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Append resolution criteria";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AppendAcceptanceCriteria_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(10, 130);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(108, 16);
			this.linkLabel2.TabIndex = 13;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Replace with title";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReplaceCommitMessageWithWorkItemTitle_LinkClicked);
			// 
			// ucCommit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.txtCommited);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAuthorDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.checkBox1);
			this.Name = "ucCommit";
			this.Size = new System.Drawing.Size(983, 444);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCommitMessage;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAuthorDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCommited;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtWorkItemTitle;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAcceptanceCriteria;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel2;
	}
}
