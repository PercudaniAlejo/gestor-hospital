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
    public partial class formSpecialField : Form
    {
        SpecialField obj;
        #region EVENTS
        public formSpecialField()
        {
            InitializeComponent();
        }

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
                SpecialField newSpeacility = new SpecialField(txtSpeciality.Text);
                SpecialField.Specialities.Add(newSpeacility);
            }
            else {
                obj.Speciality = txtSpeciality.Text;
            }
        }
        private void Clear()
        {
            txtSpeciality.Text = "";
        }

        #endregion
    }
}
