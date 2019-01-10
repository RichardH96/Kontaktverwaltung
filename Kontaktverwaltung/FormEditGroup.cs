using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontaktverwaltung.Data;

namespace Kontaktverwaltung
{
    public partial class FormEditGroup : Form
    {
        FormMain formMain = null;
        Group group = null;
        int maxInfo = 0;

        public FormEditGroup()
        {
            InitializeComponent();
        }

        public FormEditGroup(Group group, FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.group = group;
            this.textBoxName.Text = group.Name;
            this.textBoxInfo.Text = group.Info;

            if (group.Info != null)
            {
                foreach (char c in group.Info)
                    maxInfo++;
            }
            

            if(this.group.members.Count != 0)
            {
                foreach (Contact contact in this.formMain.allContacts)
                {
                    if (this.group.members.Contains(contact.ID))
                        createItem(contact);
                }
            }
            
        }

        //############################ Buttons ########################################
        #region Buttons


        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.group.Name = this.textBoxName.Text;
            this.group.Info = this.textBoxInfo.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddContactsToGroup form = new FormAddContactsToGroup(this.group, this.formMain);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                ListViewItem item = null;
                this.listView1.Items.Clear();

                foreach(Contact contact in this.formMain.allContacts)
                {
                    if (this.group.members.Contains(contact.ID))
                    {
                        item = new ListViewItem();
                        item.Tag = contact;
                        item.Text = $"{contact.Surname} {contact.Name}";
                        item.ImageIndex = 0;
                        this.listView1.Items.Add(item);
                    }
                    
                }
            }
        }


        //############################ Events ########################################
        #region Methods

        private void createItem(Contact contact)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = contact;
            item.Text = $"{contact.Surname} {contact.Name}";
            item.ImageIndex = 0;
            this.listView1.Items.Add(item);
        }


        #endregion



        #endregion

        //############################ Events ########################################
        #region Events



        private void textBoxInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                if (maxInfo > 0)
                    maxInfo--;

                if (maxInfo < 25)
                    this.labelMax.Visible = false;
            }
            else if (maxInfo == 25)
            {
                this.labelMax.Visible = true;
                this.textBoxInfo.Text.TrimEnd();
            }

        }


        #endregion

        
    }
}
