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
    public partial class ConsultationMenu : Form
    {
        public ConsultationMenu()
        {
            InitializeComponent(); 
            dgvconsult.DataSource = null;
            dgvconsult.DataSource = Consultation.Consultations;
        }
        private void ConsultationMenu_Load(object sender, EventArgs e)
        {
            dgvconsult.DataSource = null;
            dgvconsult.DataSource = Consultation.Consultations;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            NewConsultation f = new NewConsultation();
            f.ShowDialog();
            dgvconsult.DataSource = null;
            dgvconsult.DataSource = Consultation.Consultations;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Consultation selected = Selected();
            if (selected != null)
            {
                if (Consultation.Delete(selected))
                {
                    MessageBox.Show("Consultation deleted succesfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Search();
                }
                else
                    MessageBox.Show("Error.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Select consultation to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        #region METHODS
        private Consultation Selected()
        {
            if (dgvconsult.CurrentRow != null)
                return dgvconsult.CurrentRow.DataBoundItem as Consultation;
            return null;
        }
        private void Search()
        {
            dgvconsult.DataSource = null;
            dgvconsult.DataSource = Consultation.Search(txtbuscon.Text);
        }
        #endregion


    }
}
