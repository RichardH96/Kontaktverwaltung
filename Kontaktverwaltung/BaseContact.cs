using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontaktverwaltung.Data;

namespace Kontaktverwaltung
{
	public partial class BaseContact : UserControl
	{
		private Contact contact = null;
		FormMain formMain = null;

        //######################## constructors #####################################
        #region constructors    

        public BaseContact()
		{
			InitializeComponent();
		}

		public BaseContact(Contact contact, FormMain formMain)
		{
			InitializeComponent();
			this.contact = contact;
			this.formMain = formMain;
			this.labelFullName.Text = $"{contact.Surname} {contact.Name}";
			this.labelEmail.Text = contact.Email;
			this.labelBirthdate.Text = contact.Birthdate.ToString("dd.MM.yyyy");
			string[] temp = contact.Telnr.Split('-');
			this.labelTelnr.Text = $"{temp[0]} {temp[1]} {temp[2]}";
		}


        #endregion


        private void myDoubleClickHandler(object sender, EventArgs e)
		{
			FormAddContact form = new FormAddContact(contact);
			form.ShowDialog();
			if(form.DialogResult== DialogResult.OK)
			{
                formMain.sortContactList();
				formMain.save();
				formMain.fillPanel();
			}
		}


        //############################ Favorites ########################################
        #region Favorites

        

        private void toolStripMenuItemFav_Click(object sender, EventArgs e)
        {
            if (this.toolStripMenuItemFav.Text == "Add to Favorites")
            {
                contact.favorite = true;
            }
            else if (this.toolStripMenuItemFav.Text == "Remove from Favorites") 
            {
                contact.favorite = false;
            }
        }


        private void contextMenuStripContacts_Opening(object sender, CancelEventArgs e)
        {
            if (contact.favorite == false)
            {
                this.toolStripMenuItemFav.Text = "Add to Favorites";
            }
            else if (contact.favorite == true)
            {
                this.toolStripMenuItemFav.Text = "Remove from Favorites";
            }
        }




        #endregion


    }
}
