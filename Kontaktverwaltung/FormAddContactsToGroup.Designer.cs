namespace Kontaktverwaltung
{
    partial class FormAddContactsToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddContactsToGroup));
            this.groupBoxAllContacts = new System.Windows.Forms.GroupBox();
            this.listViewAllContacts = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxContactsInGroup = new System.Windows.Forms.GroupBox();
            this.listViewContactsInGroup = new System.Windows.Forms.ListView();
            this.columnHeaderName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxAllContacts.SuspendLayout();
            this.groupBoxContactsInGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAllContacts
            // 
            this.groupBoxAllContacts.Controls.Add(this.listViewAllContacts);
            this.groupBoxAllContacts.Location = new System.Drawing.Point(10, 12);
            this.groupBoxAllContacts.Name = "groupBoxAllContacts";
            this.groupBoxAllContacts.Size = new System.Drawing.Size(327, 426);
            this.groupBoxAllContacts.TabIndex = 0;
            this.groupBoxAllContacts.TabStop = false;
            this.groupBoxAllContacts.Text = "Alle Kontakte";
            // 
            // listViewAllContacts
            // 
            this.listViewAllContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName});
            this.listViewAllContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAllContacts.Location = new System.Drawing.Point(3, 18);
            this.listViewAllContacts.Name = "listViewAllContacts";
            this.listViewAllContacts.Size = new System.Drawing.Size(321, 405);
            this.listViewAllContacts.TabIndex = 0;
            this.listViewAllContacts.UseCompatibleStateImageBehavior = false;
            this.listViewAllContacts.View = System.Windows.Forms.View.Details;
            this.listViewAllContacts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewAllContacts_MouseDoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 316;
            // 
            // groupBoxContactsInGroup
            // 
            this.groupBoxContactsInGroup.Controls.Add(this.listViewContactsInGroup);
            this.groupBoxContactsInGroup.Location = new System.Drawing.Point(466, 12);
            this.groupBoxContactsInGroup.Name = "groupBoxContactsInGroup";
            this.groupBoxContactsInGroup.Size = new System.Drawing.Size(326, 426);
            this.groupBoxContactsInGroup.TabIndex = 0;
            this.groupBoxContactsInGroup.TabStop = false;
            this.groupBoxContactsInGroup.Text = "Kontakte in der Guppe";
            // 
            // listViewContactsInGroup
            // 
            this.listViewContactsInGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName1});
            this.listViewContactsInGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewContactsInGroup.Location = new System.Drawing.Point(3, 18);
            this.listViewContactsInGroup.Name = "listViewContactsInGroup";
            this.listViewContactsInGroup.Size = new System.Drawing.Size(320, 405);
            this.listViewContactsInGroup.TabIndex = 0;
            this.listViewContactsInGroup.UseCompatibleStateImageBehavior = false;
            this.listViewContactsInGroup.View = System.Windows.Forms.View.Details;
            this.listViewContactsInGroup.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewContactsInGroup_MouseDoubleClick);
            // 
            // columnHeaderName1
            // 
            this.columnHeaderName1.Text = "Name";
            this.columnHeaderName1.Width = 316;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(281, 459);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(100, 28);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Fertig";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(421, 459);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddContactsToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 511);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxContactsInGroup);
            this.Controls.Add(this.groupBoxAllContacts);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddContactsToGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meine Kontakte - Gruppe bearbeiten";
            this.Load += new System.EventHandler(this.FormAddContactsToGroup_Load);
            this.groupBoxAllContacts.ResumeLayout(false);
            this.groupBoxContactsInGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAllContacts;
        private System.Windows.Forms.GroupBox groupBoxContactsInGroup;
        private System.Windows.Forms.ListView listViewAllContacts;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ListView listViewContactsInGroup;
        private System.Windows.Forms.ColumnHeader columnHeaderName1;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonCancel;
    }
}