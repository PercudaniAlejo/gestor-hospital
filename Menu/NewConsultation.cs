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
        Consultation obj;
        public NewConsultation()
        {
            InitializeComponent();
            cmbPaciente.DataSource = null;
            cmbPaciente.DataSource = Pacient.Pacients;
            cmbdoctor.DataSource = null;
            cmbdoctor.DataSource = Doctor.Doctors;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            Save();
            Clear();
        }
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
        private void Clear()
        {
            txtdescrip.Text = "";
            cmbdoctor.SelectedItem = null;
            cmbPaciente.SelectedItem = null;
            dtpCD.Value = new DateTime(2021,1,1);
        }

    }
}
