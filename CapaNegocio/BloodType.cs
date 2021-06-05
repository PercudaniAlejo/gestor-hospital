using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class BloodType
    {
        #region Var
        private string btype;
        private static List<BloodType> btypes = new List<BloodType>();
        #endregion

        #region Properties
        public string Btype { get => btype; set => btype = value; }
        public static List<BloodType> Btypes { get => btypes; set => btypes = value; }
        #endregion

        #region methods
        public override string ToString()
        {
            return btype;
        }
        #endregion

        #region builders
        public BloodType()
        {
            btype = "default";
        }
        #endregion
    }
}
