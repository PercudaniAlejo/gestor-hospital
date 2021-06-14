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
            lblContactoMail.Text = actual.Contact.Mail;
            lblPaciente.Text = actual.ToString();
        }
    }
}
