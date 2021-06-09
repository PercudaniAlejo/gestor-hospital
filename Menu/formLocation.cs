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
        #region EVENTS

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Save();
            Clear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion
        #region METHODS
        private void Save()
        {
            if (obj == null)
            {
                CapaNegocio.Location.Obj = new CapaNegocio.Location(txtRoom.Text, txtBed.Text, dtpDateOfArrival.Value);
                CapaNegocio.Location.Locations.Add(CapaNegocio.Location.Obj);
                this.Close();
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
            dtpDateOfArrival.Value = new DateTime(2021, 1, 1);
        }

        #endregion

    }
}
