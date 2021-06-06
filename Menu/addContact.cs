using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace Menu
{
    public partial class addContact : Form
    {
        Contact c;
        public addContact()
        {
            InitializeComponent();
        }
        #region Events
        private void addContact_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Save();
            Clean();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clean();
        }

        #endregion

        #region Functions
        private void Save()
        {
            if (c == null)
            {
                Contact contact = new Contact(txtEmail.Text, (int)nudNP.Value,(int)nudNP2.Value,txttutor.Text);
                Contact.Contacts.Add(contact);
            }
            else
            {
                c.Mail = txtEmail.Text;
                c.NumberPhone = (int)nudNP.Value;
                c.TutorsPhone = (int)nudNP2.Value;
                c.Tutor1 = txttutor.Text;

            }

        }
        private void Clean()
        {
            txtEmail.Text = "";
            nudNP.Value = 0;
            nudNP2.Value = 0;
            txttutor.Text = "";
        }

        #endregion


    }
}
