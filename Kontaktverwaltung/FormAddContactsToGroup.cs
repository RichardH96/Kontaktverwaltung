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
    public partial class FormAddContactsToGroup : Form
    {
        List<Contact> allContacts = new List<Contact>();
        Group group = null;


        public FormAddContactsToGroup()
        {
            InitializeComponent();
        }

        public FormAddContactsToGroup(Group group, FormMain formMain)
        {
            InitializeComponent();
            foreach (Contact contact in formMain.allContacts)
                this.allContacts.Add(contact);


            this.group = group;

            foreach(Contact contact in group.Members)
            {
                this.allContacts.Remove(contact);
            }

        }



        //############################ Buttons ########################################
        #region Buttons


        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        #endregion

        //############################ Events ########################################
        #region Events



        private void FormAddContactsToGroup_Load(object sender, EventArgs e)
        {
            ListViewItem item = null;

            foreach(Contact contact in this.allContacts)
            {
                item = new ListViewItem();
                item.Tag = contact;
                item.Text = $"{contact.Surname} {contact.Name}";
                this.listViewAllContacts.Items.Add(item);
            }

            foreach (Contact contact in this.group.Members)
            {
                item = new ListViewItem();
                item.Tag = contact;
                item.Text = $"{contact.Surname} {contact.Name}";
                this.listViewContactsInGroup.Items.Add(item);
            }
        }


        private void listViewAllContacts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewAllContacts.GetItemAt(e.X, e.Y);
            this.group.Members.Add((Contact)item.Tag);
            this.listViewAllContacts.Items.Remove(item);
            this.listViewContactsInGroup.Items.Add(item);
            
        }

        private void listViewContactsInGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewContactsInGroup.GetItemAt(e.X, e.Y);
            this.group.Members.Remove((Contact)item.Tag);
            this.listViewContactsInGroup.Items.Remove(item);
            this.listViewAllContacts.Items.Add(item);
        }









        #endregion


    }
}
