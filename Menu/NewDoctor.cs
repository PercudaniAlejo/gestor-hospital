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
        Doctor obj;
        #region EVENTS
        public NewDoctor()
        {
            InitializeComponent();
        }
        private void NewDoctor_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region METHODS
        private void Save()
        {
            if (obj == null){

                Doctor newDoc = new Doctor(txtName.Text, txtSurname.Text, (int)nudDocumentNum.Value,
                                            cmbDocumentType.SelectedItem as formDocument,
                                            cmbSpecialField.SelectedItem as SpecialField, dateDateOfBirth.Value);
                Doctor.Doctors.Add(newDoc);
            }
            else{

            }
        }
        #endregion
    }
}
