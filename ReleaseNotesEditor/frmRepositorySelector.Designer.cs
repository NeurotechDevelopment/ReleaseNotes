using GitTfsRestServiceProxy.DataClasses;

namespace ReleaseNotesEditor
{
	partial class frmRepositorySelector
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepositorySelector));
			this.ucRepositoryContainer1 = new ReleaseNotesEditor.GuiControls.ucRepositoryContainer();
			this.SuspendLayout();
			// 
			// ucRepositoryContainer1
			// 
			this.ucRepositoryContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ucRepositoryContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ucRepositoryContainer1.DataSource = ((System.Collections.Generic.IEnumerable<Repository>)(resources.GetObject("ucRepositoryContainer1.DataSource")));
			this.ucRepositoryContainer1.Location = new System.Drawing.Point(24, 12);
			this.ucRepositoryContainer1.Name = "ucRepositoryContainer1";
			this.ucRepositoryContainer1.Size = new System.Drawing.Size(672, 522);
			this.ucRepositoryContainer1.TabIndex = 0;
			// 
			// frmRepositorySelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 546);
			this.Controls.Add(this.ucRepositoryContainer1);
			this.Name = "frmRepositorySelector";
			this.Text = "Select repository";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}



		#endregion

		private GuiControls.ucRepositoryContainer ucRepositoryContainer1;
	}
}

