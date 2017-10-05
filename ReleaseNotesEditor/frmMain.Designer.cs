namespace ReleaseNotesEditor
{
	partial class frmMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.openRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openCommitEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRepositoryToolStripMenuItem,
            this.openCommitEditorToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(735, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// openRepositoryToolStripMenuItem
			// 
			this.openRepositoryToolStripMenuItem.Name = "openRepositoryToolStripMenuItem";
			this.openRepositoryToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
			this.openRepositoryToolStripMenuItem.Text = "Open repository";
			this.openRepositoryToolStripMenuItem.Click += new System.EventHandler(this.openRepositoryToolStripMenuItem_Click);
			// 
			// openCommitEditorToolStripMenuItem
			// 
			this.openCommitEditorToolStripMenuItem.Name = "openCommitEditorToolStripMenuItem";
			this.openCommitEditorToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
			this.openCommitEditorToolStripMenuItem.Text = "Open commit editor";
			this.openCommitEditorToolStripMenuItem.Click += new System.EventHandler(this.openCommitEditorToolStripMenuItem_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 456);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.Text = "Release Notes Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem openRepositoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openCommitEditorToolStripMenuItem;
	}
}