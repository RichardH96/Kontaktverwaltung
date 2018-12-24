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
			this.labelFullName = new System.Windows.Forms.Label();
			this.labelBirthdate = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelTelnr = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelFullName
			// 
			this.labelFullName.AutoSize = true;
			this.labelFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFullName.Location = new System.Drawing.Point(23, 3);
			this.labelFullName.Name = "labelFullName";
			this.labelFullName.Size = new System.Drawing.Size(65, 16);
			this.labelFullName.TabIndex = 0;
			this.labelFullName.Text = "fullName";
			this.labelFullName.DoubleClick += new System.EventHandler(this.myDoubleClickHandler);
			// 
			// labelBirthdate
			// 
			this.labelBirthdate.AutoSize = true;
			this.labelBirthdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBirthdate.Location = new System.Drawing.Point(184, 2);
			this.labelBirthdate.Name = "labelBirthdate";
			this.labelBirthdate.Size = new System.Drawing.Size(66, 16);
			this.labelBirthdate.TabIndex = 0;
			this.labelBirthdate.Text = "Birthdate";
			this.labelBirthdate.DoubleClick += new System.EventHandler(this.myDoubleClickHandler);
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEmail.Location = new System.Drawing.Point(323, 2);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(44, 16);
			this.labelEmail.TabIndex = 0;
			this.labelEmail.Text = "Email";
			this.labelEmail.DoubleClick += new System.EventHandler(this.myDoubleClickHandler);
			// 
			// labelTelnr
			// 
			this.labelTelnr.AutoSize = true;
			this.labelTelnr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTelnr.Location = new System.Drawing.Point(558, 2);
			this.labelTelnr.Name = "labelTelnr";
			this.labelTelnr.Size = new System.Drawing.Size(41, 16);
			this.labelTelnr.TabIndex = 0;
			this.labelTelnr.Text = "TelNr";
			this.labelTelnr.DoubleClick += new System.EventHandler(this.myDoubleClickHandler);
			// 
			// BaseContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.labelTelnr);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.labelBirthdate);
			this.Controls.Add(this.labelFullName);
			this.Name = "BaseContact";
			this.Size = new System.Drawing.Size(745, 21);
			this.DoubleClick += new System.EventHandler(this.myDoubleClickHandler);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelFullName;
		private System.Windows.Forms.Label labelBirthdate;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelTelnr;
	}
}
