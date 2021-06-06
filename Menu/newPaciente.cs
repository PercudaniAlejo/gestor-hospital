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
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (obj==null)
            {
                Pacient pacient = new Pacient(txtName.Text, txtSurname.Text, dateDateOfBirth.Value, cmbgender.SelectedItem, (int)nudDocumentNum.Value, btnAddContact, cmbDocumentType.SelectedItem as Document, cmbBloodType.SelectedItem);// no funca
            }
        }

        private void newPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
