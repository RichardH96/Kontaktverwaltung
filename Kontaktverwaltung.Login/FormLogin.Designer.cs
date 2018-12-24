namespace Kontaktverwaltung.Login
{
	partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.buttonRegister = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.labelPasswordRepeat = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelUsername = new System.Windows.Forms.Label();
			this.textBoxPasswordRepeat = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonRegister
			// 
			this.buttonRegister.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRegister.Location = new System.Drawing.Point(157, 190);
			this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(85, 28);
			this.buttonRegister.TabIndex = 5;
			this.buttonRegister.Text = "Registrieren";
			this.buttonRegister.UseVisualStyleBackColor = true;
			this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCancel.Location = new System.Drawing.Point(249, 190);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(85, 28);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Abbrechen";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonLogin
			// 
			this.buttonLogin.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.Location = new System.Drawing.Point(62, 190);
			this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(85, 28);
			this.buttonLogin.TabIndex = 3;
			this.buttonLogin.Text = "Einloggen";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// labelPasswordRepeat
			// 
			this.labelPasswordRepeat.AutoSize = true;
			this.labelPasswordRepeat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPasswordRepeat.Location = new System.Drawing.Point(46, 154);
			this.labelPasswordRepeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPasswordRepeat.Name = "labelPasswordRepeat";
			this.labelPasswordRepeat.Size = new System.Drawing.Size(138, 15);
			this.labelPasswordRepeat.TabIndex = 7;
			this.labelPasswordRepeat.Text = "Passwort wiederholen:";
			this.labelPasswordRepeat.Visible = false;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPassword.Location = new System.Drawing.Point(46, 120);
			this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(65, 15);
			this.labelPassword.TabIndex = 8;
			this.labelPassword.Text = "Passwort:";
			// 
			// labelLogin
			// 
			this.labelLogin.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLogin.Location = new System.Drawing.Point(9, 25);
			this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(378, 41);
			this.labelLogin.TabIndex = 9;
			this.labelLogin.Text = "LOGIN";
			this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelUsername
			// 
			this.labelUsername.AutoSize = true;
			this.labelUsername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUsername.Location = new System.Drawing.Point(46, 88);
			this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(93, 15);
			this.labelUsername.TabIndex = 10;
			this.labelUsername.Text = "Benutzername:";
			// 
			// textBoxPasswordRepeat
			// 
			this.textBoxPasswordRepeat.BackColor = System.Drawing.Color.Silver;
			this.textBoxPasswordRepeat.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPasswordRepeat.Location = new System.Drawing.Point(184, 152);
			this.textBoxPasswordRepeat.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
			this.textBoxPasswordRepeat.Size = new System.Drawing.Size(166, 19);
			this.textBoxPasswordRepeat.TabIndex = 2;
			this.textBoxPasswordRepeat.Visible = false;
			this.textBoxPasswordRepeat.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPasswordRepeat_Validating);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.Color.Silver;
			this.textBoxPassword.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword.Location = new System.Drawing.Point(184, 119);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(166, 19);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.Text = "admin";
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.BackColor = System.Drawing.Color.Silver;
			this.textBoxUsername.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUsername.Location = new System.Drawing.Point(184, 86);
			this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(166, 19);
			this.textBoxUsername.TabIndex = 0;
			this.textBoxUsername.Text = "admin";
			this.textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsername_Validating);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(396, 243);
			this.Controls.Add(this.buttonRegister);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.labelPasswordRepeat);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelLogin);
			this.Controls.Add(this.labelUsername);
			this.Controls.Add(this.textBoxPasswordRepeat);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUsername);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Meine Kontakte - Login";
			this.Load += new System.EventHandler(this.FormLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonRegister;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Label labelPasswordRepeat;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.TextBox textBoxPasswordRepeat;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxUsername;
	}
}

