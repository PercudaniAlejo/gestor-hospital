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
    public partial class PacientMenu : Form
    {
        public PacientMenu()
        {
            InitializeComponent();
            dgvPacient.DataSource = null;
            dgvPacient.DataSource = Pacient.Pacients;
        }
        private Pacient Selected()
        {
            if (dgvPacient.CurrentRow != null)
                return dgvPacient.CurrentRow.DataBoundItem as Pacient;
            return null;
        }

        private void btnNewPacient_Click(object sender, EventArgs e)
        {
            newPaciente newPaciente = new newPaciente();
            newPaciente.ShowDialog();
            dgvPacient.DataSource = null;
            dgvPacient.DataSource = Pacient.Pacients;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Pacient selected = Selected();
            if (selected != null)
            {
                if (Pacient.Delete(selected))
                {
                    MessageBox.Show("Doctor deleted succesfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPacient.DataSource = null;
                    dgvPacient.DataSource = Pacient.Pacients;
                }
                else
                    MessageBox.Show("Error.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Select doctor to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFilterPacient_Click(object sender, EventArgs e)
        {

        }
    }
    
}
