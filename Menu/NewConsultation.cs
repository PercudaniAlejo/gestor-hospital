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
    public partial class NewConsultation : Form
    {
        Consultation obj = null;
        public NewConsultation(Consultation modifyConsult = null)
        {
            InitializeComponent();
            if (modifyConsult != null)
            {
                obj = modifyConsult;
                Modify(obj);
            }

            cmbPaciente.DataSource = null;
            cmbPaciente.DataSource = Pacient.Pacients;
            cmbdoctor.DataSource = null;
            cmbdoctor.DataSource = Doctor.Doctors;
        }
        #region EVENTS
        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (Control())
                MessageBox.Show("Error. Empty fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else { 
                Save();
                Clear();
            }
        }

        #endregion

        #region METHODS

        private void Save()
        {
            if (obj == null)
            {

                Consultation newConsultation = new Consultation(txtdescrip.Text, cmbdoctor.SelectedItem as Doctor,
                                            cmbPaciente.SelectedItem as Pacient,dtpCD.Value);
                Consultation.Consultations.Add(newConsultation);
            }
            else
            {
                obj.Description = txtdescrip.Text;
                obj.Doctor = cmbdoctor.SelectedItem as Doctor;
                obj.Pacient = cmbPaciente.SelectedItem as Pacient;
                obj.ConsultationDate = dtpCD.Value;
            }
        }
        private bool Control() {
            if (txtdescrip.Text == "" ||
                cmbdoctor.SelectedItem == null ||
                cmbPaciente.SelectedItem == null)
            {
                return true;
            }
            return false;
        }

        private void Clear()
        {
            txtdescrip.Text = "";
            cmbdoctor.SelectedItem = null;
            cmbPaciente.SelectedItem = null;
            dtpCD.Value = new DateTime(2021,1,1);
        }

        private void Modify(Consultation modifyConsult) {
            txtdescrip.Text = obj.Description;
            cmbdoctor.SelectedItem = obj.Doctor;
            cmbPaciente.SelectedItem = obj.Pacient;
            dtpCD.Value = obj.ConsultationDate;
        }
        #endregion
    }
}
