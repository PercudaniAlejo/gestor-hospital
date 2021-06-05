using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class Doctor
    {
        #region VM
        private string name;
        private string surname;
        private int documentNumber;
        private Document documentType;
        private SpecialField specialField;
        private DateTime dateOfBirth;
        private static List<Doctor> doctors = new List<Doctor>();
        #endregion

        #region PROPERTIES
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int DocumentNumber { get => documentNumber; set => documentNumber = value; }
        public Document DocumentType { get => documentType; set => documentType = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        internal SpecialField SpecialField { get => specialField; set => specialField = value; }
        public static List<Doctor> Doctors { get => doctors; set => doctors = value; }
        #endregion

        #region BUILDERS
        public Doctor() 
        {
            name = "";
            surname = "";
            documentNumber = 0;
            documentType = null;
            specialField = null;
            dateOfBirth = new DateTime(1900, 1, 1);
        }

        public Doctor(string name, string surname, int documentNumber, Document documentType, SpecialField specialField, DateTime dateOfBirth)
        {
            this.name = name;
            this.surname = surname;
            this.documentNumber = documentNumber;
            this.documentType = documentType;
            this.specialField = specialField;
            this.dateOfBirth = dateOfBirth;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return name + "" + surname + "" + dateOfBirth.ToShortDateString() + "" + specialField + "" + documentType + "" + documentNumber;
        }
        #endregion

    }
}
