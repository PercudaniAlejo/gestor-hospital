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
    public partial class formLocation : Form
    {
        CapaNegocio.Location obj;
        public formLocation()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
        #region METHODS
        private void Save()
        {
            if (obj == null)
            {
                CapaNegocio.Location NewLoc = new CapaNegocio.Location(txtBed.Text,dtpDateOfArrival.Value,txtRoom.Text);
                CapaNegocio.Location.Locations.Add(NewLoc);
            }
            else
            {
                obj.Assignedbed = txtBed.Text;
                obj.Dateofarrival = dtpDateOfArrival.Value;
                obj.Room = txtRoom.Text;
            }
        }
        private void Clear()
        {
            txtRoom.Text = "";
            txtBed.Text = "";
            dtpDateOfArrival.Value = new DateTime(2021,1,1);
        }

        #endregion
    }
}
