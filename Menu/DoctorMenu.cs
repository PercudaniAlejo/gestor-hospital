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
    public partial class DoctorMenu : Form
    {
        public DoctorMenu()
        {
            InitializeComponent();
            dgvDoctorMenu.DataSource = null;
            dgvDoctorMenu.DataSource = Doctor.Doctors;
        }
        #region EVENTS
        private void btnNewPacient_Click(object sender, EventArgs e)
        {
            NewDoctor formNewDoctor = new NewDoctor();
            formNewDoctor.ShowDialog();
            dgvDoctorMenu.DataSource = null;
            dgvDoctorMenu.DataSource = Doctor.Doctors;
        }

        private void btndeletedoc_Click(object sender, EventArgs e)
        {
            Doctor selected = Selected();
            if (selected != null)
            {
                if (Doctor.Delete(selected))
                {
                    MessageBox.Show("Doctor deleted succesfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDoctorMenu.DataSource = null;
                    dgvDoctorMenu.DataSource = Doctor.Doctors;
                }
                else
                    MessageBox.Show("Error.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Select doctor to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region METHODS
        private Doctor Selected()
        {
            if (dgvDoctorMenu.CurrentRow != null)
                return dgvDoctorMenu.CurrentRow.DataBoundItem as Doctor;
            return null;
        }
        #endregion
    }
}
