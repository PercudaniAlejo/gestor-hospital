using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class SpecialField
    {
        #region VM
        private string speciality;
        private static List<SpecialField> specialities = new List<SpecialField>();

        #endregion

        #region PROPERTIES
        public string Speciality { get => speciality; set => speciality = value; }
        public static List<SpecialField> Specialities { get => specialities; set => specialities = value; }
        #endregion

        #region BUILDERS
        public SpecialField(){
            speciality = "";
        }

        public SpecialField(string speciality){
            this.speciality = speciality;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return speciality + "";
        }
        #endregion
    }
}
