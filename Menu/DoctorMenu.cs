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
            NewDoctor f = new NewDoctor();
            f.ShowDialog();
            dgvDoctorMenu.DataSource = null;
            dgvDoctorMenu.DataSource = Doctor.Doctors;
        }


        #endregion

        #region METHODS
        #endregion
    }
}
