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
    public partial class FormGroups : Form
    {
        List<Group> allGroups = null;
        FormMain formMain = null;


        public FormGroups()
        {
            InitializeComponent();
        }

        public FormGroups(List<Group> allGroups, FormMain formMain)
        {
            InitializeComponent();
            this.allGroups = allGroups;
            this.formMain = formMain;
        }


        //############################ Buttons ########################################
        #region Buttons



        private void buttonDone_Click(object sender, EventArgs e)
        {
            
            foreach(ListViewItem item in this.listViewGroups.Items)
            {
                if (item.Checked == true)
                {
                    this.formMain.selectedGroup = (Group)item.Tag;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            FormEditGroup form = new FormEditGroup(group, this.formMain);
            form.Show();

            if (form.DialogResult == DialogResult.OK)
            {
                allGroups.Add(group);
                createItem();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this.listViewGroups.Items)
            {
                if (item.Checked == true)
                {
                    Group group = (Group)item.Tag;
                    if (MessageBox.Show($"Wollen Sie wirklich die Gruppe \"{group.Name}\" löschen?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.allGroups.Remove(group);
                        createItem();
                    }

                }
            }
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listViewGroups.Items)
            {
                if (item.Checked == true)
                {
                    FormEditGroup form = new FormEditGroup((Group)item.Tag, this.formMain);
                    form.Show();

                    if (form.DialogResult == DialogResult.OK)
                    {
                        createItem();
                    }
                    break;
                }
            }
        }






        #endregion

        //############################ Methods ########################################
        #region Methods

        private void createItem()
        {
            this.listViewGroups.Items.Clear();

            ListViewItem item = null;
            foreach (Group group in allGroups)
            {
                item = new ListViewItem();
                item.Tag = group;
                item.Text = group.Name;
                item.SubItems.Add(group.Info);
                item.SubItems.Add(group.Members.Count.ToString());
                this.listViewGroups.Items.Add(item);
            }
            
            
        }

        #endregion


        //############################ Events ########################################
        #region Events



        private void FormGroups_Load(object sender, EventArgs e)
        {
            createItem();
        }

        private void listViewGroups_MouseClick(object sender, MouseEventArgs e)
        {
            this.listViewGroups.Items.Clear();
            ListViewItem item = this.listViewGroups.GetItemAt(e.X, e.Y);

            foreach (Contact contact in ((Group)item.Tag).Members)
            {
                item = new ListViewItem();
                item.Tag = contact;
                item.Text = $"{contact.Surname} {contact.Name}";
                item.ImageIndex = 0;
                this.listViewContacts.Items.Add(item);
            }
        }

        private void listViewGroups_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewGroups.GetItemAt(e.X, e.Y);

            this.formMain.selectedGroup = (Group)item.Tag;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        #endregion


    }
}
