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
    public partial class FormDetails : Form
    {
        Pacient actual;
        public FormDetails(Pacient p)
        {
            InitializeComponent();
            actual = p;
        }

        private void FormEjemplo_Load(object sender, EventArgs e)
        {
            if (actual != null)
            {
                lblPS.Text = actual.ToString();
                lblDOBs.Text = actual.DateofBirth.ToShortDateString().ToString();
                lblGS.Text = actual.Gender.ToString();
                lblNDs.Text = actual.DocumentNumber.ToString();
                lblTYPE.Text = actual.Document.ToString();
                lblBTS.Text = actual.BloodType.ToString();
                lblMails.Text = actual.Contact.Mail;
                lblPNS.Text = actual.Contact.NumberPhone.ToString();
                lblTNS.Text = actual.Contact.Tutor.ToString();
                lblTPS.Text = actual.Contact.TutorsPhone.ToString();
                lblLS.Text = actual.Location.ToString();
                lblNS.Text = actual.HealthInsurance.Name.ToString();
                lblPlanS.Text = actual.HealthInsurance.Plan.ToString();
                lblNumberS.Text = actual.HealthInsurance.Number.ToString();
                lblDDS.Text = actual.HealthInsurance.DueDate.ToShortDateString().ToString();
                lblTS.Text = actual.HealthInsurance.Typehi.ToString();
            }

        }


    }
}
