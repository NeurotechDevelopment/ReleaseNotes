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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCommitId = new System.Windows.Forms.TextBox();
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
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(112, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Commit Id:";
			// 
			// txtCommitId
			// 
			this.txtCommitId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCommitId.Location = new System.Drawing.Point(188, 8);
			this.txtCommitId.Name = "txtCommitId";
			this.txtCommitId.ReadOnly = true;
			this.txtCommitId.Size = new System.Drawing.Size(800, 22);
			this.txtCommitId.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 117);
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
			this.txtCommitMessage.Location = new System.Drawing.Point(3, 136);
			this.txtCommitMessage.Multiline = true;
			this.txtCommitMessage.Name = "txtCommitMessage";
			this.txtCommitMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCommitMessage.Size = new System.Drawing.Size(985, 146);
			this.txtCommitMessage.TabIndex = 3;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(3, 4);
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
			this.label3.Location = new System.Drawing.Point(118, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Authored:";
			// 
			// txtAuthorDate
			// 
			this.txtAuthorDate.Location = new System.Drawing.Point(187, 35);
			this.txtAuthorDate.Name = "txtAuthorDate";
			this.txtAuthorDate.ReadOnly = true;
			this.txtAuthorDate.Size = new System.Drawing.Size(311, 22);
			this.txtAuthorDate.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(525, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Commited:";
			// 
			// txtCommited
			// 
			this.txtCommited.Location = new System.Drawing.Point(603, 36);
			this.txtCommited.Name = "txtCommited";
			this.txtCommited.ReadOnly = true;
			this.txtCommited.Size = new System.Drawing.Size(336, 22);
			this.txtCommited.TabIndex = 6;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(3, 285);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(96, 16);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "View work item";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewWorkItem_LinkClicked);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Work item title:";
			// 
			// txtWorkItemTitle
			// 
			this.txtWorkItemTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtWorkItemTitle.Location = new System.Drawing.Point(105, 67);
			this.txtWorkItemTitle.Name = "txtWorkItemTitle";
			this.txtWorkItemTitle.ReadOnly = true;
			this.txtWorkItemTitle.Size = new System.Drawing.Size(739, 22);
			this.txtWorkItemTitle.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(850, 67);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Replace comment";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btnReplaceCommitMessageWithWotkItemTitle_Click);
			// 
			// ucCommit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtWorkItemTitle);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.txtCommited);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAuthorDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.txtCommitMessage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCommitId);
			this.Controls.Add(this.label1);
			this.Name = "ucCommit";
			this.Size = new System.Drawing.Size(1000, 310);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCommitId;
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
		private System.Windows.Forms.Button button1;
	}
}
