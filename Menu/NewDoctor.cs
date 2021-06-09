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
    public partial class NewDoctor : Form
    {
        Doctor obj, newDoc;
        public NewDoctor(Doctor modifyDoctor = null)
        {
            InitializeComponent();
            if (modifyDoctor != null)
            {
                obj = modifyDoctor;
                Modify(obj);
            }
        }

        #region EVENTS
        private void NewDoctor_Load(object sender, EventArgs e)
        {
            cmbDocumentType.DataSource = null;
            cmbDocumentType.DataSource = Document.DocTypes;

            cmbSpecialField.DataSource = null;
            cmbSpecialField.DataSource = SpecialField.Specialities;
        }
        private void btnfield_Click(object sender, EventArgs e)
        {
            formSpecialField formSF = new formSpecialField();
            formSF.ShowDialog();
            cmbSpecialField.DataSource = null;
            cmbSpecialField.DataSource = SpecialField.Specialities;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Control())
                MessageBox.Show("Error. Empty fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Save();
                Clear();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion

        #region METHODS
        private void Save()
        {
            if (obj == null){

                newDoc = new Doctor(txtName.Text, txtSurname.Text, (int)nudDocumentNum.Value,
                                            cmbDocumentType.SelectedItem as Document,
                                            cmbSpecialField.SelectedItem as SpecialField, dateDateOfBirth.Value);
                Doctor.Doctors.Add(newDoc);
            }
            else{
                obj.Name = txtName.Text;
                obj.Surname = txtSurname.Text;
                obj.DocumentNumber = (int)nudDocumentNum.Value;
                obj.DocumentType = cmbDocumentType.SelectedItem as Document;
                obj.SpecialField = cmbSpecialField.SelectedItem as SpecialField;
                obj.DateOfBirth = dateDateOfBirth.Value;
            }
        }
        private void Clear()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            nudDocumentNum.Value= 0;
            dateDateOfBirth.Value = new DateTime(1900, 1, 1);
            cmbDocumentType.SelectedItem = null;
            cmbSpecialField.SelectedItem = null;
        }

        private bool Control()
        {
            if (txtName.Text == "" ||
                txtSurname.Text == "" ||
                nudDocumentNum.Value == 0)
                return true;
            return false;
        }

        private void Modify(Doctor modifyDoctor) {
            txtName.Text = obj.Name;
            txtSurname.Text = obj.Surname;
            nudDocumentNum.Value = obj.DocumentNumber;
            cmbDocumentType.SelectedItem = obj.DocumentType;
            cmbSpecialField.SelectedItem = obj.SpecialField;
            dateDateOfBirth.Value = obj.DateOfBirth;
        }
        #endregion
    }
}
