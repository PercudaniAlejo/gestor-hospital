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
    public partial class DoctorMenu : Form
    {
        public DoctorMenu()
        {
            InitializeComponent();
        }

        private void btnNewPacient_Click(object sender, EventArgs e)
        {
            NewDoctor f = new NewDoctor();
            f.ShowDialog();
        }
    }
}
