using Kontaktverwaltung.Data;
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

namespace Kontaktverwaltung
{
    public partial class FormMain : Form
    {

        string username = string.Empty;
        string savepath = string.Empty;
        User thisUser = null;
        public List<Contact> allContacts = new List<Contact>();
        List<Contact> searchList = new List<Contact>();
        List<Group> allGroups = new List<Group>();
        List<int> allIDs = new List<int>();

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(User userLogin)
        {
            InitializeComponent();
            this.thisUser = userLogin;
            this.username = userLogin.username;
            this.savepath = userLogin.savepath;
        }

        public Group selectedGroup { get; set; }



        //############################# Menu - Program ######################################
        #region Menu - Program

        //+++++++++++++++++++++++++++++ New Contact ++++++++++++++++++++++++++++++++++
        #region New Contact


        private void MenuItemNewContact_Click(object sender, EventArgs e)
        {
            bool thisID = true;
            Contact contact = new Contact();
            for (int i = 1; i < 10000; i++)
            {
                foreach (Contact contact1 in this.allContacts)
                {
                    if (i == contact1.ID)
                    {
                        thisID = false;
                        break;
                    }
                        
                }

                if (thisID == true)
                {
                    contact.ID = i;
                    allIDs.Add(i);
                    break;
                }
            }
            FormAddContact form = new FormAddContact(contact);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                allContacts.Add(contact);
                this.flowLayoutPanelMain.Controls.Clear();

                sortContactList();

                fillPanel();

                save();

            }
        }


        #endregion

        //+++++++++++++++++++++++++++++ Exit ++++++++++++++++++++++++++++++++++
        #region Exit


        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #endregion

        //############################# Menu - Settings ######################################
        #region Menu - Settings

        //+++++++++++++++++++++++++++++ ManuelSavepath ++++++++++++++++++++++++++++++++++
        #region ManuelSavepath


        private void saveManuelPath()
        {
            List<User> allUsers = null;
            string path = "C:\\Solutions\\Kontaktverwaltung\\Data\\User.xml";

            StreamReader reader = new StreamReader(path, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            allUsers = (List<User>)serializer.Deserialize(reader);
            reader.Close();

            foreach (User user in allUsers)
            {
                if (user.username == this.thisUser.username)
                {
                    allUsers.Remove(user);
                    break;
                }
            }

            allUsers.Add(this.thisUser);

            StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8);
            serializer.Serialize(writer, allUsers);
            writer.Close();

        }

        private void setSavepathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML-File|*.xml|All Files|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.Delete(savepath);
                savepath = dialog.FileName;
                save();
                saveManuelPath();
            }
        }
        #endregion





        #endregion




        //############################# Buttons ######################################
        #region Buttons


        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            this.labelTitle.Text = "Kontakte: Favoriten";
            fillPanelFav();
        }


        private void buttonAllContacts_Click(object sender, EventArgs e)
        {
            this.labelTitle.Text = "Kontakte:";
            fillPanel();
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            FormGroups form = new FormGroups(allGroups, this);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK) 
            {
                this.labelTitle.Text = $"Kontakte: \"{this.selectedGroup.Name}\"";
                fillPanelGroup();
            }

        }




        #endregion




        //############################# FillPanelMethods ######################################
        #region FillPanelMethods


        public void fillPanel()
        {
            this.flowLayoutPanelMain.Controls.Clear();
            BaseContact baseContact = null;


            foreach (Contact contact in allContacts)
            {
                baseContact = new BaseContact(contact, this);
                baseContact.Tag = contact;
                this.flowLayoutPanelMain.Controls.Add(baseContact);
            }

        }

        public void fillPanelFav()
        {
            this.flowLayoutPanelMain.Controls.Clear();
            BaseContact baseContact = null;

            foreach (Contact contact in allContacts)
            {
                if (contact.favorite == true)
                {
                    baseContact = new BaseContact(contact, this);
                    baseContact.Tag = contact;
                    this.flowLayoutPanelMain.Controls.Add(baseContact);
                }
            }
        }

        public void fillPanelSearch(List<Contact> list)
        {
            this.flowLayoutPanelMain.Controls.Clear();
            BaseContact baseContact = null;

            foreach (Contact contact in list)
            {
                baseContact = new BaseContact(contact, this);
                baseContact.Tag = contact;
                this.flowLayoutPanelMain.Controls.Add(baseContact);
            }

        }

        private void fillPanelGroup()
        {
            this.flowLayoutPanelMain.Controls.Clear();
            BaseContact baseContact = null;

            foreach (Contact contact in this.allContacts)
            {
                if (selectedGroup.members.Contains(contact.ID))
                {
                    baseContact = new BaseContact(contact, this);
                    baseContact.Tag = contact;
                    this.flowLayoutPanelMain.Controls.Add(baseContact);
                }
                
            }
        }

        #endregion

        //############################# SaveMethod ######################################
        #region SaveMethod


        public void save()
        {
            SaveThis save = new SaveThis();

            save.allContacts = this.allContacts;
            save.allGroups = this.allGroups;
            save.usedIDs = this.allIDs;

            StreamWriter writer = new StreamWriter(savepath, false, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(SaveThis));
            serializer.Serialize(writer, save);
            writer.Close();
        }












        #endregion

        //############################# ABCSortMethod ######################################
        #region ABCSortMethod

        public void sortContactList()
        {
            List<Contact> temp = new List<Contact>();

            foreach (Contact contact in allContacts)
            {
                temp.Add(contact);
            }
            allContacts.Clear();
            
            Contact addToList = null;
            int i = 0;

            do
            {
                bool conflict = false;
                foreach (Contact contact in temp)
                {
                    if (contact.Surname[0] == i)
                    {
                        if (addToList == null)
                        {
                            addToList = contact;
                        }
                        else
                        {
                            conflict = true;
                            for (int idx = 1; idx < addToList.Surname.Length; idx++)
                            {
                                if (addToList.Surname[idx] > contact.Surname[idx])
                                {
                                    addToList = contact;
                                    break;
                                }
                                else if(addToList.Surname[idx] < contact.Surname[idx])
                                {
                                    break;
                                }
                                
                            }



                        }

                    }

                }

                if (addToList != null)
                {
                    this.allContacts.Add(addToList);
                    temp.Remove(addToList);
                    addToList = null;
                }
                


                if(!conflict) i++;

            } while (temp.Count > 0);

            //save??
        }





        #endregion

        





        //############################# Form_Load ######################################
        #region Form_Load

        private void FormMain_Load(object sender, EventArgs e)
        {
            bool done = false;



            do
            {
                if (savepath == null)
                {
                    MessageBox.Show("Bitte wählen Sie einen Speicherpfad.", "Wichtig!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "XML-File|*.xml|All Files|*.*";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        this.thisUser.savepath = dialog.FileName;
                        this.savepath = dialog.FileName;
                        saveManuelPath();
                        save();
                        done = true;
                    }
                }
                else
                {
                    done = true;
                }
            } while (done == false);


            if (File.Exists(savepath))
            {
                SaveThis save = new SaveThis();

                StreamReader reader = new StreamReader(this.savepath, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(SaveThis));
                save = (SaveThis)serializer.Deserialize(reader);
                reader.Close();

                this.allContacts = save.allContacts;
                this.allGroups = save.allGroups;
                this.allIDs = save.usedIDs;

                fillPanel();


            }
            this.toolStripStatusUser.Text = $"angemeldeter Benutzer: {this.username}";


        }

        #endregion

        //############################# Search_Events ######################################
        #region Search_Events


        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                searchList.Clear();
            }

        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (searchList.Count == 0)
            {
                foreach (Contact contact in allContacts)
                {
                    if (contact.Name.Contains(this.textBoxSearch.Text) || contact.Surname.Contains(this.textBoxSearch.Text))
                    {
                        searchList.Add(contact);
                    }
                }
            }
            else
            {
                bool conflict = false;
                do
                {
                    conflict = false;
                    foreach (Contact contact in searchList)
                    {
                        if (contact.Name.Contains(this.textBoxSearch.Text) || contact.Surname.Contains(this.textBoxSearch.Text))
                        {

                        }
                        else
                        {
                            searchList.Remove(contact);
                            conflict = true;
                            break;
                        }
                    }
                } while (conflict);

            }



            fillPanelSearch(searchList);
        }



        #endregion

        
    }
}
