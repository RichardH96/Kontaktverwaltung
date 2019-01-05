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

        //######################## constructor ############################
        #region constructor


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

        #endregion


        //######################## Buttons ############################
        #region Buttons


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
        #endregion


        //######################## Textboxen Validated ############################
        #region Textboxen Validated



        private void textBoxName_Validated(object sender, EventArgs e)
        {
            string temp = string.Empty;

            if (this.textBoxName.Text != string.Empty)
            {
                if (this.textBoxName.Text[0] >= 97)
                {
                    bool firstLetter = true;
                    foreach (char c in this.textBoxName.Text)
                    {
                        if (firstLetter)
                        {
                            temp += Convert.ToChar(((int)c) - 32);
                            firstLetter = false;
                        }
                        else
                        {
                            temp += c;
                        }

                    }
                    this.textBoxName.Text = temp;
                }
            }





        }

        private void textBoxSurname_Validated(object sender, EventArgs e)
        {
            string temp = string.Empty;

            if (this.textBoxSurname.Text != string.Empty)
            {
                if (this.textBoxSurname.Text[0] >= 97)
                {
                    bool firstLetter = true;
                    foreach (char c in this.textBoxSurname.Text)
                    {
                        if (firstLetter)
                        {
                            temp += Convert.ToChar(((int)c) - 32);
                            firstLetter = false;
                        }
                        else
                        {
                            temp += c;
                        }

                    }
                    this.textBoxSurname.Text = temp;
                }
            }
           
        }

        private void textBoxStreet_Validated(object sender, EventArgs e)
        {
            string temp = string.Empty;

            if (this.textBoxStreet.Text != string.Empty)
            {
                if (this.textBoxStreet.Text[0] >= 97)
                {
                    bool firstLetter = true;
                    foreach (char c in this.textBoxStreet.Text)
                    {
                        if (firstLetter)
                        {
                            temp += Convert.ToChar(((int)c) - 32);
                            firstLetter = false;
                        }
                        else
                        {
                            temp += c;
                        }

                    }
                    this.textBoxStreet.Text = temp;
                }
            }
            
        }

        private void textBoxOrt_Validated(object sender, EventArgs e)
        {
            string temp = string.Empty;

            if (this.textBoxOrt.Text != string.Empty)
            {
                if (this.textBoxOrt.Text[0] >= 97)
                {
                    bool firstLetter = true;
                    foreach (char c in this.textBoxOrt.Text)
                    {
                        if (firstLetter)
                        {
                            temp += Convert.ToChar(((int)c) - 32);
                            firstLetter = false;
                        }
                        else
                        {
                            temp += c;
                        }

                    }
                    this.textBoxOrt.Text = temp;
                }
            }
            
        }




        #endregion


    }
}
