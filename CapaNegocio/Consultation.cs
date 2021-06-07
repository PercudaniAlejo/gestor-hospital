﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
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
            consultationDate = new DateTime(2021,1,1);
        }

        public Consultation(string description, Doctor doctor, Pacient pacient,DateTime consultationDate)
        {
            this.description = description;
            this.doctor = doctor;
            this.pacient = pacient;
            this.consultationDate = consultationDate;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return description + "" + doctor + "" + consultationDate.ToShortDateString() + "" + pacient;
        }
        #endregion
    }
}
