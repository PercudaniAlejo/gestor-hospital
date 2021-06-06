﻿using System;
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
        #region events
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (obj == null)
            {
                // Contact obj2;
                //obj2.NumberPhone=
                //  addContact con = new addContact();
                // Pacient pacient = new Pacient(txtName.Text, txtSurname.Text, dateDateOfBirth.Value, cmbgender.SelectedItem, (int)nudDocumentNum.Value, obj2, cmbDocumentType.SelectedItem as Document, cmbBloodType.SelectedItem, );// no funca
            }
        }

        private void newPaciente_Load(object sender, EventArgs e)
        {       
                cmbBloodType.DataSource = null;
                cmbBloodType.DataSource = BloodType.Btypes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            addContact f = new addContact();
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
            cmbBloodType.SelectedItem =null;
            cmbDocumentType.SelectedItem = null;
            cmbgender.SelectedItem = null;
        }
        #endregion
    }
}
