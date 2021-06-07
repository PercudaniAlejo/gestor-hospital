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
        }
        #region events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            HealthInsurance.Obj = new HealthInsurance(txtName.Text,txtPlan.Text,(int)nudHealthInsurenceNum.Value,dateDueDate.Value,txtType.Text);
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

    }
}
