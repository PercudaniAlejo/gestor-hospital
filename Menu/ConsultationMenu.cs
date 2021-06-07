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

        private void btnadd_Click(object sender, EventArgs e)
        {
            NewConsultation f = new NewConsultation();
            f.ShowDialog();
        }
    }
}
