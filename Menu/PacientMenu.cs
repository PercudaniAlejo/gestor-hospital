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
        Pacient objpac;
        public PacientMenu()
        {
            InitializeComponent();
            DGVLoad();
        }
        private Pacient Selected()
        {
            if (dgvPacient.CurrentRow != null)
                return dgvPacient.CurrentRow.DataBoundItem as Pacient;
            return null;
        }

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
        private void Search()
        {
            dgvPacient.DataSource = null;
            dgvPacient.DataSource = Doctor.Search(txtFilterPacient.Text);
        }
        private void DGVLoad()
        {
            dgvPacient.DataSource = null;
            dgvPacient.DataSource = Pacient.Pacients.ToList();
            //dgvPacient.DataSource = HealthInsurance.Healthinsurances.ToList();
            

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

}

}
