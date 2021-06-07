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
        public newPaciente(Pacient objpac = null)
        {
            InitializeComponent();

            if (objpac != null)
            {
                obj = objpac;
                modify(obj);
            }
            cmbgender.SelectedItem = null;
            cmbBloodType.SelectedItem = null;
            cmbDocumentType.SelectedItem = null;
        }
        #region events
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Save();
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

        private void Save() {
            if (obj == null)
            {
                Pacient pacient = new Pacient(txtName.Text, txtSurname.Text, dateDateOfBirth.Value, cmbgender.SelectedItem as Gender, (int)nudDocumentNum.Value, Contact.Obj, cmbDocumentType.SelectedItem as Document, cmbBloodType.SelectedItem as BloodType, HealthInsurance.Obj, CapaNegocio.Location.Obj);// no funca
                Pacient.Pacients.Add(pacient);
                Clean();
            }
            else
            {
                obj.Name = txtName.Text;
                obj.Surname = txtSurname.Text;
                obj.DateofBirth = dateDateOfBirth.Value;
                obj.Gender = cmbgender.SelectedItem as Gender;
                obj.Document = cmbDocumentType.SelectedItem as Document;
                obj.BloodType = cmbBloodType.SelectedItem as BloodType;
                obj.DocumentNumber = (int)nudDocumentNum.Value;
                obj.Contact = Contact.Obj;
                obj.HealthInsurance = HealthInsurance.Obj;
                obj.Location = CapaNegocio.Location.Obj;
            }
        }
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
        private void modify(Pacient obj)
        {
            txtName.Text = obj.Name;
            txtSurname.Text = obj.Surname;
            nudDocumentNum.Value = obj.DocumentNumber;
            cmbBloodType.SelectedItem = obj.BloodType;
            cmbDocumentType.SelectedItem = obj.Document;
            cmbgender.SelectedItem = obj.Gender;
            dateDateOfBirth.Value = obj.DateofBirth;
        }


        #endregion
    }
}
