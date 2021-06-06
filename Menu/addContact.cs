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
        private void checkBoxMother_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMother.Checked)
            {
                checkBoxFather.Checked = false;
                checkBoxTutor.Checked = false;
            }

        }

        private void checkBoxFather_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFather.Checked)
            {
                checkBoxMother.Checked = false;
                checkBoxTutor.Checked = false;
            }

        }

        private void checkBoxTutor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTutor.Checked)
            {
                checkBoxFather.Checked = false;
                checkBoxMother.Checked = false;
            }

        }
        #endregion

        #region Functions
        private void Save()
        {
            if (c == null)
            {
                Contact contact = new Contact(txtEmail.Text, (int)nudNP.Value, (int)nudNP2.Value, checkBoxMother.Checked, checkBoxFather.Checked, checkBoxTutor.Checked);//no anda 
                Contact.Contacts.Add(contact);
            }
            else
            {
                c.Mail = txtEmail.Text;
                c.NumberPhone = (int)nudNP.Value;
                c.TutorsPhone = (int)nudNP2.Value;

            }

        }
        private void Clean()
        {
            txtEmail.Text = "";
            nudNP.Value = 0;
            checkBoxMother = null;
            nudNP2.Value = 0;
        }

        #endregion


    }
}
