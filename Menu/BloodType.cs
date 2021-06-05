using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class BloodType
    {
        #region Var
        private string assignedbed;
        private DateTime dateofarrival;
        private string room;
        private static List<BloodType> bloodtypes = new List<BloodType>();
        #endregion

        #region Properties
        public string Assignedbed { get => assignedbed; set => assignedbed = value; }
        public DateTime Dateofarrival { get => dateofarrival; set => dateofarrival = value; }
        public string Room { get => room; set => room = value; }
        public static List<BloodType> Bloodtypes { get => bloodtypes; set => bloodtypes = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return assignedbed + " " + dateofarrival.ToShortDateString() + " " + room;
        }
        #endregion

        #region Builders
        public BloodType()
        {
            assignedbed = "Default";
            dateofarrival = new DateTime(2021,1,1);
            room = "Default";
        }
        #endregion
    }
}
