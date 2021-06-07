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
    public partial class addHealthInsurence : Form
    {
        public addHealthInsurence()
        {
            InitializeComponent();
            dgvhi.DataSource = null;
            dgvhi.DataSource = HealthInsurance.Obj;
        }
        #region events
     private void btnCancel_Click(object sender, EventArgs e)
        {
            Clean();
        }
        #endregion
   
        #region functions
        private void Clean()
        {
            txtName.Text = "";
            txtPlan.Text = "";
            txtType.Text = "";
            dateDueDate.Value = new DateTime(2021, 1, 1);
            nudHealthInsurenceNum.Value = 0;
            
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*Doctor selected = Selected();
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
                MessageBox.Show("Select doctor to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            HealthInsurance.Obj = new HealthInsurance(txtName.Text,txtPlan.Text,(int)nudHealthInsurenceNum.Value,dateDueDate.Value,txtType.Text);
        }
    }
}
