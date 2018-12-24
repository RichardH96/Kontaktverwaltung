using Kontaktverwaltung.Data;
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

namespace Kontaktverwaltung
{
	public partial class FormMain : Form
	{
		string username=string.Empty;
		string savepath = string.Empty;
		List<Contact> allContacts = new List<Contact>();

		public FormMain()
		{
			InitializeComponent();
		}

		public FormMain(string username)
		{
			InitializeComponent();
			this.username = username;
			this.savepath = $"C:\\Solutions\\Kontaktverwaltung\\Data\\{username}.xml";
		}



		#region Menu - Program

		

		private void MenuItemNewContact_Click(object sender, EventArgs e)
		{
			Contact contact = new Contact();
			FormAddContact form = new FormAddContact(contact);
			form.ShowDialog();

			if(form.DialogResult==DialogResult.OK)
			{
				allContacts.Add(contact);
				this.flowLayoutPanelMain.Controls.Clear();
				
				fillPanel();
				
				save();
				
			}
		}

		

		private void MenuItemExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}




		#endregion

		private void FormMain_Load(object sender, EventArgs e)
		{
			if (File.Exists(savepath))
			{
				StreamReader reader = new StreamReader(this.savepath, Encoding.UTF8);
				XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
				this.allContacts = (List<Contact>)serializer.Deserialize(reader);
				reader.Close();
				
				fillPanel();
				

			}
			this.toolStripStatusUser.Text = this.username;


		}


		public void fillPanel()
		{
			this.flowLayoutPanelMain.Controls.Clear();
			foreach(Contact contact in allContacts)
			{
				BaseContact baseContact = new BaseContact(contact, this);
				baseContact.Tag = contact;
				this.flowLayoutPanelMain.Controls.Add(baseContact);
			}
			
		}

		public void save()
		{
			StreamWriter writer = new StreamWriter(savepath, false, Encoding.UTF8);
			XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
			serializer.Serialize(writer, allContacts);
			writer.Close();
		}
	}
}
