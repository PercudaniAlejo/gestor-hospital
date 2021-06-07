using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Location
    {
        #region Var
        private string assignedbed;
        private DateTime dateofarrival;
        private string room;
        private static List<Location> locations = new List<Location>();
        static CapaNegocio.Location obj;
        #endregion

        #region Properties
        public string Assignedbed { get => assignedbed; set => assignedbed = value; }
        public DateTime Dateofarrival { get => dateofarrival; set => dateofarrival = value; }
        public string Room { get => room; set => room = value; }
        public static List<Location> Locations { get => locations; set => locations = value; }
        public static Location Obj { get => obj; set => obj = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return assignedbed + " " + dateofarrival.ToShortDateString() + " " + room;
        }
        #endregion

        #region Builders
        public Location()
        {
            assignedbed = "Default";
            dateofarrival = new DateTime(2021, 1, 1);
            room = "Default";
        }
        public Location(string assignedbed, DateTime dateofarrival, string room)
        {
            this.assignedbed = assignedbed;
            this.dateofarrival = dateofarrival;
            this.room = room;
        }
        #endregion
    }
}
