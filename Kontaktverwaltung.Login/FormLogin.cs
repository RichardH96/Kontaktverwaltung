using Kontaktverwaltung.Login.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Kontaktverwaltung.Login
{
	public partial class FormLogin : Form
	{
		List<User> regUsers = new List<User>();
        User userLogin = null;
		string savepath = "C:\\Solutions\\Kontaktverwaltung\\Data\\User.xml";
		bool registermode = false;

		//##################Construtor######################

		#region constructor


		public FormLogin()
		{
			InitializeComponent();
		}

		public FormLogin(string username)
		{
			InitializeComponent();
		}

		#endregion



		public string UserName
		{
			get { return this.textBoxUsername.Text; }
			set { this.textBoxUsername.Text = value; }
		}


        public User UserLogin
        {
            get { return userLogin; }
            set { userLogin = value; }
        }



        //##################Buttons######################

        #region Buttons

        private void buttonRegister_Click(object sender, EventArgs e)
		{
			registermode = true;
			changeToRegister();
		}



		private void buttonLogin_Click(object sender, EventArgs e)
		{
			bool userExists = false;

			if (registermode)
			{
				foreach(User user in regUsers)
				{
					if (user.username == this.textBoxUsername.Text)
					{
						userExists = true;
					}
				}


				if (!userExists)
				{
					User user = new User();
					user.username = this.textBoxUsername.Text;
					user.password = encodingPassword(this.textBoxPassword.Text);
					this.regUsers.Add(user);
					saveUser();
					this.DialogResult = DialogResult.OK;
					this.Close();
				}




			}
			else
			{

				foreach (User user in regUsers)
				{
					if(user.username == this.textBoxUsername.Text)
					{
                        userLogin = user;
						if(decodingPassword(user.password) == this.textBoxPassword.Text)
						{
							this.DialogResult = DialogResult.OK;
							this.Close();
						}
					}
				}
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			if (registermode)
			{
				registermode = false;
				changeToRegister();
			}
			else
			{
				this.Close();
			}
		}

		#endregion

		//##################Registermode######################

		#region Registermode

		
		private void changeToRegister()
		{
			if (registermode)
			{
				this.textBoxPassword.Text = string.Empty;
				this.textBoxPasswordRepeat.Text = string.Empty;
				this.textBoxUsername.Text = string.Empty;

				this.textBoxPassword.UseSystemPasswordChar = false;

				this.labelPasswordRepeat.Visible = true;
				this.textBoxPasswordRepeat.Visible = true;
				this.labelLogin.Text = "REGISTRIEREN";
				this.Text = "Meine Kontakte - Registieren";

				this.buttonRegister.Visible = false;

				this.buttonLogin.Text = "Bestätigen";
			}
			else if (!registermode)
			{
				this.textBoxPassword.Text = string.Empty;
				this.textBoxPasswordRepeat.Text = string.Empty;
				this.textBoxUsername.Text = string.Empty;

				this.textBoxPassword.UseSystemPasswordChar = true;

				this.labelPasswordRepeat.Visible = false;
				this.textBoxPasswordRepeat.Visible = false;
				this.labelLogin.Text = "LOGIN";
				this.Text = "Meine Kontakte - Login";

				this.buttonRegister.Visible = true;

				this.buttonLogin.Text = "Einloggen";
				
			}

		}


		#endregion

		//##################Encoding######################

		#region Encoding

		public string encodingPassword(string str)
		{
			byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
			return Convert.ToBase64String(encbuff);
		}
		public string decodingPassword(string str)
		{
			byte[] decbuff = Convert.FromBase64String(str);
			return System.Text.Encoding.UTF8.GetString(decbuff);
		}

		//public string encodingPassword(string password)
		//{
		//	string result = string.Empty;
		//	int charVal = 0;

		//	for (int i = 0; i < password.Length; i++) 
		//	{
		//		charVal = password[i] + i + 1;
		//		result += charVal.ToString("x2");
		//	}
		//	return result;
		//}

		//public string decodingPassword(string password)
		//{
		//	string result = string.Empty;
		//	string hex = string.Empty;
		//	int charVal = 0;

		//	for (int i = 0; i < password.Length; i += 2) 
		//	{
		//		hex = Text.Substring(i, 2);
		//		charVal = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
		//		charVal -= (i / 2) + 1;
		//		result += Convert.ToChar(charVal);
		//	}
		//	return result;
		//}


		#endregion

		private void FormLogin_Load(object sender, EventArgs e)
		{
			if(File.Exists(savepath))
			{
				StreamReader reader = new StreamReader(savepath, Encoding.UTF8);
				XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
				this.regUsers = (List<User>)serializer.Deserialize(reader);
				reader.Close();
			}

		}

		private void saveUser()
		{
			StreamWriter writer = new StreamWriter(savepath, false, Encoding.UTF8);
			XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
			serializer.Serialize(writer, regUsers);
			writer.Close();
		}



		//##################Validating######################

		#region Validating



		private void textBoxPasswordRepeat_Validating(object sender, CancelEventArgs e)
		{
			if (this.textBoxPassword.Text != this.textBoxPasswordRepeat.Text)
			{
				this.textBoxPassword.BackColor = Color.MistyRose;
				this.textBoxPasswordRepeat.BackColor = Color.MistyRose;
				e.Cancel = true;
			}
			else
			{
				this.textBoxPassword.BackColor = Color.Silver;
				this.textBoxPasswordRepeat.BackColor = Color.Silver;
			}

		}

		private void textBoxUsername_Validating(object sender, CancelEventArgs e)
		{
			if(registermode)
			{
				foreach (User user in regUsers)
				{
					if (user.username == this.textBoxUsername.Text)
					{
						this.textBoxUsername.BackColor = Color.MistyRose;
						e.Cancel = true;
					}
					else
					{
						this.textBoxUsername.BackColor = Color.Silver;
					}
				}
			}
			
		}

		#endregion


	}
}
