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
    public partial class newPaciente : Form
    {

        Pacient obj;
        public newPaciente()
        {
            InitializeComponent();
            cmbgender.SelectedItem = null;
            cmbBloodType.SelectedItem = null;
            cmbDocumentType.SelectedItem = null;
        }
        #region events
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (obj == null)
            {
                Pacient pacient = new Pacient(txtName.Text, txtSurname.Text, dateDateOfBirth.Value, cmbgender.SelectedItem as Gender, (int)nudDocumentNum.Value,Contact.Obj , cmbDocumentType.SelectedItem as Document, cmbBloodType.SelectedItem as BloodType, HealthInsurance.Obj, CapaNegocio.Location.Obj);// no funca
                Pacient.Pacients.Add(pacient);
            }
        }

        private void newPaciente_Load(object sender, EventArgs e)
        {
            cmbBloodType.DataSource = null;
            cmbBloodType.DataSource = BloodType.Btypes;
            cmbgender.DataSource = null;
            cmbgender.DataSource = Gender.Gen;
            cmbDocumentType.DataSource = null;
            cmbDocumentType.DataSource = Document.DocTypes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            DateTime tempAge = dateDateOfBirth.Value;
            addContact f = new addContact(tempAge);
            f.ShowDialog();
        }

        private void btnHealtInsurence_Click(object sender, EventArgs e)
        {
            addHealthInsurence f = new addHealthInsurence();
            f.ShowDialog();
        }

        private void btnocationPacient_Click(object sender, EventArgs e)
        {
            formLocation f = new formLocation();
            f.ShowDialog();
        }
        #endregion

        #region functions
        private void Clean()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            dateDateOfBirth.Value = new DateTime(1900, 1, 1);
            nudDocumentNum.Value = 0;
            cmbBloodType.SelectedItem = null;
            cmbDocumentType.SelectedItem = null;
            cmbgender.SelectedItem = null;
        }     
        #endregion
    }
}
