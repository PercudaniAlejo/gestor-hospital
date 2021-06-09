using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Location
    {
        #region Var 
        private string room;
        private string assignedbed;
        private DateTime dateofarrival;

        private static List<Location> locations = new List<Location>();
        static CapaNegocio.Location obj;
        #endregion

        #region Properties 
        public string Room { get => room; set => room = value; }
        public string Assignedbed { get => assignedbed; set => assignedbed = value; }
        public DateTime Dateofarrival { get => dateofarrival; set => dateofarrival = value; }
        public static List<Location> Locations { get => locations; set => locations = value; }
        public static Location Obj { get => obj; set => obj = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return room + " " + assignedbed + " " + dateofarrival.ToShortDateString();
        }
        #endregion

        #region Builders
        public Location()
        {
            room = "Default";
            assignedbed = "Default";
            dateofarrival = new DateTime(2021, 1, 1);

        }
        public Location(string room, string assignedbed, DateTime dateofarrival)
        {
            this.room = room;
            this.assignedbed = assignedbed;
            this.dateofarrival = dateofarrival;

        }
        #endregion
    }
}
