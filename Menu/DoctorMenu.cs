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
        Doctor objDoctor;
         
        public DoctorMenu()
        {
            InitializeComponent();
            dgvLoad();
        }
        #region EVENTS
        private void btnNewPacient_Click(object sender, EventArgs e)
        {
            NewDoctor formNewDoctor = new NewDoctor();
            formNewDoctor.ShowDialog();
            dgvLoad();
        }
        private void btnFilterDoc_Click(object sender, EventArgs e)
        {
                Search();
         

        }
        private void btneditdoc_Click(object sender, EventArgs e)
        {
            objDoctor = Selected();
            NewDoctor nD = new NewDoctor(objDoctor);
            nD.ShowDialog();
            dgvLoad();
        }
        private void btndeletedoc_Click(object sender, EventArgs e)
        {
            Doctor selected = Selected();
            if (selected != null)
            {
                if (Doctor.Delete(selected))
                {
                    MessageBox.Show("Doctor deleted succesfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Search();
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

        private void Search() {
            dgvDoctorMenu.DataSource = null;
            dgvDoctorMenu.DataSource = Doctor.Search(txtFilterDoc.Text);
        }

        private void dgvLoad() {
            dgvDoctorMenu.DataSource = null;
            dgvDoctorMenu.DataSource = Doctor.Doctors.ToList();
        }
        #endregion

    }
}
