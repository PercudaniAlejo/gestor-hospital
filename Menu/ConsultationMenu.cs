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
        Consultation objConsult;
        public ConsultationMenu()
        {
            InitializeComponent();
            dgvLoad();
        }
        #region events
        private void btnadd_Click(object sender, EventArgs e)
        {
            NewConsultation fa = new NewConsultation();
            fa.ShowDialog();
            dgvLoad();
        }
        private void btnbuscon_Click(object sender, EventArgs e)
        {
            Search();
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            objConsult = Selected();
            NewConsultation nC = new NewConsultation(objConsult);
            nC.ShowDialog();
            dgvLoad();
        }
        #endregion

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

        private void dgvLoad()
        {
            dgvconsult.DataSource = null;
            dgvconsult.DataSource = Consultation.Consultations.ToList();
        }

        #endregion
    }
}
