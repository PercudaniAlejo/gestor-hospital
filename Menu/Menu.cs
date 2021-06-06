using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btnPacient_Click(object sender, EventArgs e)
        {
            PacientMenu f = new PacientMenu();
            f.ShowDialog();
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            Document f = new Document();
            f.ShowDialog();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorMenu f = new DoctorMenu();
            f.ShowDialog();
        }
    }
}
