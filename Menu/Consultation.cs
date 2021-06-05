using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class Consultation
    {
        #region VM
        private string description;
        private Doctor doctor;
        private Pacient pacient;
        private DateTime consultationDate;
        private static List<Consultation> consultations = new List<Consultation>();
        #endregion

        #region PROPERTIES
        public string Description { get => description; set => description = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }
        public Pacient Pacient { get => pacient; set => pacient = value; }
        public DateTime ConsultationDate { get => consultationDate; set => consultationDate = value; }
        public static List<Consultation> Consultations { get => consultations; set => consultations = value; }
        #endregion

        #region BUILDERS
        public Consultation()
        {
            description = "";
            doctor = null;
            pacient = null;
        }

        public Consultation(string description, Doctor doctor, Pacient pacient)
        {
            this.description = description;
            this.doctor = doctor;
            this.pacient = pacient;
        }
        #endregion

        #region METHODS
        #endregion
    }
}
