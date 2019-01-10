namespace Kontaktverwaltung
{
    partial class FormGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroups));
            this.groupBoxGroups = new System.Windows.Forms.GroupBox();
            this.listViewGroups = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMembers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxMembers = new System.Windows.Forms.GroupBox();
            this.listViewContacts = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.groupBoxGroups.SuspendLayout();
            this.groupBoxMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGroups
            // 
            this.groupBoxGroups.Controls.Add(this.listViewGroups);
            this.groupBoxGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxGroups.Location = new System.Drawing.Point(159, 12);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Size = new System.Drawing.Size(624, 361);
            this.groupBoxGroups.TabIndex = 0;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Gruppen";
            // 
            // listViewGroups
            // 
            this.listViewGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderInfo,
            this.columnHeaderMembers});
            this.listViewGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGroups.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewGroups.FullRowSelect = true;
            this.listViewGroups.GridLines = true;
            this.listViewGroups.Location = new System.Drawing.Point(3, 18);
            this.listViewGroups.MultiSelect = false;
            this.listViewGroups.Name = "listViewGroups";
            this.listViewGroups.Size = new System.Drawing.Size(618, 340);
            this.listViewGroups.TabIndex = 0;
            this.listViewGroups.UseCompatibleStateImageBehavior = false;
            this.listViewGroups.View = System.Windows.Forms.View.Details;
            this.listViewGroups.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewGroups_MouseClick);
            this.listViewGroups.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewGroups_MouseDoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 177;
            // 
            // columnHeaderInfo
            // 
            this.columnHeaderInfo.Text = "Info";
            this.columnHeaderInfo.Width = 338;
            // 
            // columnHeaderMembers
            // 
            this.columnHeaderMembers.Text = "Mitglieder";
            this.columnHeaderMembers.Width = 95;
            // 
            // buttonDone
            // 
            this.buttonDone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(401, 430);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(124, 42);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Fertig";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(546, 430);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 42);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxMembers
            // 
            this.groupBoxMembers.Controls.Add(this.listViewContacts);
            this.groupBoxMembers.Location = new System.Drawing.Point(800, 12);
            this.groupBoxMembers.Name = "groupBoxMembers";
            this.groupBoxMembers.Size = new System.Drawing.Size(185, 358);
            this.groupBoxMembers.TabIndex = 2;
            this.groupBoxMembers.TabStop = false;
            this.groupBoxMembers.Text = "Mitglieder";
            // 
            // listViewContacts
            // 
            this.listViewContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewContacts.Location = new System.Drawing.Point(3, 18);
            this.listViewContacts.Name = "listViewContacts";
            this.listViewContacts.Size = new System.Drawing.Size(179, 337);
            this.listViewContacts.SmallImageList = this.imageList;
            this.listViewContacts.TabIndex = 0;
            this.listViewContacts.UseCompatibleStateImageBehavior = false;
            this.listViewContacts.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "iconfinder_user-alt_285645.png");
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::Kontaktverwaltung.Properties.Resources.iconfinder_Delete_132746;
            this.buttonDelete.Location = new System.Drawing.Point(12, 108);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 33);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Gruppe löschen";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Image = global::Kontaktverwaltung.Properties.Resources.Add_16x;
            this.buttonAddGroup.Location = new System.Drawing.Point(12, 30);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(141, 33);
            this.buttonAddGroup.TabIndex = 1;
            this.buttonAddGroup.Text = "Neue Gruppe";
            this.buttonAddGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.Location = new System.Drawing.Point(12, 69);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(141, 33);
            this.buttonEditGroup.TabIndex = 1;
            this.buttonEditGroup.Text = "Gruppe bearbeiten";
            this.buttonEditGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditGroup.UseVisualStyleBackColor = true;
            this.buttonEditGroup.Click += new System.EventHandler(this.buttonEditGroup_Click);
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 515);
            this.Controls.Add(this.groupBoxMembers);
            this.Controls.Add(this.buttonEditGroup);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.groupBoxGroups);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meine Kontakte - Gruppen";
            this.Load += new System.EventHandler(this.FormGroups_Load);
            this.groupBoxGroups.ResumeLayout(false);
            this.groupBoxMembers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGroups;
        private System.Windows.Forms.ListView listViewGroups;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderInfo;
        private System.Windows.Forms.ColumnHeader columnHeaderMembers;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxMembers;
        private System.Windows.Forms.ListView listViewContacts;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.ImageList imageList;
    }
}