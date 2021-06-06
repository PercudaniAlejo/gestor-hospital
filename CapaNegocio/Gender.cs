using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Gender
    {
        #region VM
        private string genders;
        private static List<Gender> gen = new List<Gender>();
        #endregion
        #region Properties
        public string Genders { get => genders; set => genders = value; }
        public static List<Gender> Gen { get => gen; set => gen = value; }
        #endregion
        #region Methods
        public override string ToString()
        {
            return genders;
        }
        #endregion
        #region Builders
        public Gender()
        {
            genders = "";
        }
        public Gender(string genders)
        {
            this.genders = genders;
        }

        #endregion

    }
}
