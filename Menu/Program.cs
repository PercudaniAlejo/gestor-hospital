using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio;
namespace Menu
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region BloodTypesLoad
            /* BloodType.Btypes.Add(new BloodType("A+"));
               BloodType.Btypes.Add(new BloodType("A-"));
               BloodType.Btypes.Add(new BloodType("B+"));
               BloodType.Btypes.Add(new BloodType("B-"));
               BloodType.Btypes.Add(new BloodType("AB+"));
               BloodType.Btypes.Add(new BloodType("AB-"));
               BloodType.Btypes.Add(new BloodType("O+"));
               BloodType.Btypes.Add(new BloodType("O-"));*/
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());

        }
    }
}
