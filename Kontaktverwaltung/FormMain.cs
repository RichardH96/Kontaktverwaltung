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
        List<Contact> allContacts = new List<Contact>();

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
                StreamReader reader = new StreamReader(this.savepath, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
                this.allContacts = (List<Contact>)serializer.Deserialize(reader);
                reader.Close();

                fillPanel();


            }
            this.toolStripStatusUser.Text = this.username;


        }

        #endregion

        //############################# Menu - Program ######################################
        #region Menu - Program

        //+++++++++++++++++++++++++++++ New Contact ++++++++++++++++++++++++++++++++++
        #region New Contact


        private void MenuItemNewContact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            FormAddContact form = new FormAddContact(contact);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                allContacts.Add(contact);
                this.flowLayoutPanelMain.Controls.Clear();

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
            fillPanelFav();
        }


        private void buttonAllContacts_Click(object sender, EventArgs e)
        {
            fillPanel();
        }






        #endregion




        //############################# FillPanelMethod ######################################
        #region FillPanelMethod


        public void fillPanel()
        {
            this.flowLayoutPanelMain.Controls.Clear();
            
            foreach (Contact contact in allContacts)
            {
                BaseContact baseContact = new BaseContact(contact, this);
                baseContact.Tag = contact;
                this.flowLayoutPanelMain.Controls.Add(baseContact);
            }

        }

        public void fillPanelFav()
        {
            this.flowLayoutPanelMain.Controls.Clear();

            foreach (Contact contact in allContacts)
            {
                if (contact.favorite == true)
                {
                    BaseContact baseContact = new BaseContact(contact, this);
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
            StreamWriter writer = new StreamWriter(savepath, false, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
            serializer.Serialize(writer, allContacts);
            writer.Close();
        }











        #endregion

        
    }
}
