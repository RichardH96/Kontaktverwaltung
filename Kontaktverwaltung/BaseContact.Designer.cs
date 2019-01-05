namespace Kontaktverwaltung
{
	partial class BaseContact
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
            this.components = new System.ComponentModel.Container();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelnr = new System.Windows.Forms.Label();
            this.contextMenuStripContacts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemFav = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(31, 5);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(76, 19);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "fullName";
            this.labelFullName.DoubleClick += new System.EventHandler(this.myDoubleClickHandler);
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdate.Location = new System.Drawing.Point(245, 3);
            this.labelBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(82, 19);
            this.labelBirthdate.TabIndex = 0;
            this.labelBirthdate.Text = "Birthdate";
            this.labelBirthdate.DoubleClick += new System.EventHandler(this.myDoubleClickHandler);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(431, 3);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 19);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            this.labelEmail.DoubleClick += new System.EventHandler(this.myDoubleClickHandler);
            // 
            // labelTelnr
            // 
            this.labelTelnr.AutoSize = true;
            this.labelTelnr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelnr.Location = new System.Drawing.Point(744, 3);
            this.labelTelnr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelnr.Name = "labelTelnr";
            this.labelTelnr.Size = new System.Drawing.Size(50, 19);
            this.labelTelnr.TabIndex = 0;
            this.labelTelnr.Text = "TelNr";
            this.labelTelnr.DoubleClick += new System.EventHandler(this.myDoubleClickHandler);
            // 
            // contextMenuStripContacts
            // 
            this.contextMenuStripContacts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFav,
            this.toolStripMenuItem1,
            this.toolStripMenuItemGroup});
            this.contextMenuStripContacts.Name = "contextMenuStripContacts";
            this.contextMenuStripContacts.Size = new System.Drawing.Size(187, 58);
            this.contextMenuStripContacts.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripContacts_Opening);
            // 
            // toolStripMenuItemFav
            // 
            this.toolStripMenuItemFav.Name = "toolStripMenuItemFav";
            this.toolStripMenuItemFav.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItemFav.Text = "Add to Favorites";
            this.toolStripMenuItemFav.Click += new System.EventHandler(this.toolStripMenuItemFav_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // toolStripMenuItemGroup
            // 
            this.toolStripMenuItemGroup.Name = "toolStripMenuItemGroup";
            this.toolStripMenuItemGroup.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItemGroup.Text = "Add to Group";
            // 
            // BaseContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStripContacts;
            this.Controls.Add(this.labelTelnr);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.labelFullName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaseContact";
            this.Size = new System.Drawing.Size(993, 26);
            this.DoubleClick += new System.EventHandler(this.myDoubleClickHandler);
            this.contextMenuStripContacts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelFullName;
		private System.Windows.Forms.Label labelBirthdate;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelTelnr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripContacts;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFav;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}
