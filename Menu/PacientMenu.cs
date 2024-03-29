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
    public partial class PacientMenu : Form
    {
        Pacient objpac;
        public PacientMenu()
        {
            InitializeComponent();
            DGVLoad();
            
        }
        #region EVENTS


        private void btnNewPacient_Click(object sender, EventArgs e)
        {
            Contact.Obj = null;
            CapaNegocio.Location.Obj = null;
            HealthInsurance.Obj = null;

            newPaciente newPaciente = new newPaciente();
            newPaciente.ShowDialog();
            DGVLoad();
           
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            objpac = Selected();
            newPaciente np = new newPaciente(objpac);
            np.ShowDialog();
            DGVLoad();
        
        }

        private void btnFilterPacient_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            Pacient selected = Selected();
            if (selected != null)
            {
                if (Pacient.Delete(selected))
                {
                    MessageBox.Show("Pacient deleted succesfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVLoad();
                   
                }
                else
                    MessageBox.Show("Error.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Select pacient to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region METHODS

        private void Search()
        {
            try
            {
                dgvPacient.DataSource = null;
                dgvPacient.DataSource = Pacient.Search(txtFilterPacient.Text);
                dgvPacient.Columns[5].Visible = false;
                dgvPacient.Columns[9].Visible = false;
                dgvPacient.Columns[8].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DGVLoad()
        {
            dgvPacient.DataSource = null;
            dgvPacient.DataSource = Pacient.Pacients.ToList();
            dgvPacient.Columns[5].Visible = false;
            dgvPacient.Columns[9].Visible = false;
            dgvPacient.Columns[8].Visible = false;
        }

        private Pacient Selected()
        {
            if (dgvPacient.CurrentRow != null)
                return dgvPacient.CurrentRow.DataBoundItem as Pacient;
            return null;


        }



        #endregion

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Pacient p = Selected();
            FormDetails f = new FormDetails(p);
            f.ShowDialog();

        }

        private void dgvPacient_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }
    }

}
