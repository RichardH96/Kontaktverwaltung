using Kontaktverwaltung.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontaktverwaltung
{
	public partial class FormAddContact : Form
	{
		Contact contact = null;
		public FormAddContact()
		{
			InitializeComponent();
		}

		public FormAddContact(Contact contact)
		{
			InitializeComponent();
			this.contact = contact;
			if (contact.Birthdate < this.dateTimePickerBirthdate.MinDate)
			{
				contact.Birthdate = DateTime.Now;
			}
			this.dateTimePickerBirthdate.Value = contact.Birthdate;
			this.textBoxEmail.Text = contact.Email;
			this.textBoxHouseNr.Text = contact.HouseNr.ToString();
			this.textBoxName.Text = contact.Name;
			this.textBoxOrt.Text = contact.Ort;
			this.textBoxPLZ.Text = contact.PLZ.ToString();
			this.textBoxStreet.Text = contact.street;
			this.textBoxSurname.Text = contact.Surname;
			if (contact.Telnr != null)
			{
				string[] temp = contact.Telnr.Split('-');
				this.textBoxTelNr2.Text = temp[1];
				this.textBoxTelNr3.Text = temp[2];
				this.comboBoxTelNr1.Text = temp[0];
			}

            if (contact.favorite == true)
                checkBoxFav.Checked = true;
			

		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			contact.Birthdate = this.dateTimePickerBirthdate.Value;
			contact.Email = this.textBoxEmail.Text;
			contact.HouseNr = int.Parse(this.textBoxHouseNr.Text);
			contact.Name = this.textBoxName.Text;
			contact.Ort = this.textBoxOrt.Text;
			contact.PLZ = int.Parse(this.textBoxPLZ.Text);
			contact.street = this.textBoxStreet.Text;
			contact.Surname = this.textBoxSurname.Text;
			contact.Telnr = $"{this.comboBoxTelNr1.Text}-{this.textBoxTelNr2.Text}-{this.textBoxTelNr3.Text}";

            if (checkBoxFav.Checked == true)
            {
                contact.favorite = true;
            }
            else
            {
                contact.favorite = false;
            }


			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
