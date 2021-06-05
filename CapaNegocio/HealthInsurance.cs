using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class HealthInsurance
    {
        #region Var
        private string name;
        private string plan;
        private int number;
        private DateTime duedate;
        private string typehi;
        private static List<HealthInsurance> healthinsurances = new List<HealthInsurance>();
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string Plan { get => plan; set => plan = value; }
        public int Number { get => number; set => number = value; }
        public DateTime DueDate { get => duedate; set => duedate = value; }
        public string Typehi { get => typehi; set => typehi = value; }
        public static List<HealthInsurance> Healthinsurances { get => healthinsurances; set => healthinsurances = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return name + " " + plan + " " + number + " " + duedate.ToShortDateString() + " " + typehi;
        }
        #endregion

        #region Builders
        public HealthInsurance()
        {
            name = "Default";
            plan = "Default";
            number = 0;
            duedate = new DateTime(2031, 6, 5);
            typehi = "Default";
        }
        public HealthInsurance(string name, string plan, int number, DateTime duedate, string typehi)
        {
            this.name = name;
            this.plan = plan;
            this.number = number;
            this.duedate = duedate;
            this.typehi = typehi;
        }
        #endregion
    }
}
