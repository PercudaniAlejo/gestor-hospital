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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            #region BloodTypesload
            BloodType.Btypes.Add(new BloodType("A+"));
            BloodType.Btypes.Add(new BloodType("A-"));
            BloodType.Btypes.Add(new BloodType("B+"));
            BloodType.Btypes.Add(new BloodType("B-"));
            BloodType.Btypes.Add(new BloodType("AB+"));
            BloodType.Btypes.Add(new BloodType("AB-"));
            BloodType.Btypes.Add(new BloodType("O+"));
            BloodType.Btypes.Add(new BloodType("O-"));
            #endregion

            #region GenderLoad
            Gender.Gen.Add(new Gender("Male"));
            Gender.Gen.Add(new Gender("Female"));
            #endregion

        }
        private void btnPacient_Click(object sender, EventArgs e)
        {
            PacientMenu f = new PacientMenu();
            f.ShowDialog();
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            formDocument f = new formDocument();
            f.ShowDialog();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorMenu f = new DoctorMenu();
            f.ShowDialog();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            ConsultationMenu f = new ConsultationMenu();
            f.ShowDialog();
        }
    }
}
