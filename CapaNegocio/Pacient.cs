using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Pacient
    {
        #region MV
        private string name;
        private string surname;
        private DateTime dateofBirth;
        private string gender;
        private int documentNumber;
        private Contact contact;
        private Document document;
        private BloodType bloodType;
        private HealthInsurance healthInsurance;
        private Location location;
        private static List<Pacient> pacients = new List<Pacient>();
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime DateofBirth { get => dateofBirth; set => dateofBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public int DocumentNumber { get => documentNumber; set => documentNumber = value; }
        public Contact Contact { get => contact; set => contact = value; }
        public Document Document { get => document; set => document = value; }
        public BloodType BloodType { get => bloodType; set => bloodType = value; }
        public HealthInsurance HealthInsurance { get => healthInsurance; set => healthInsurance = value; }
        public Location Location { get => location; set => location = value; }
        public static List<Pacient> Pacients { get => pacients; set => pacients = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return name + "" + surname + "" + dateofBirth.ToShortDateString() + "" + gender + "" + contact + "" + document + "" + documentNumber + "" + bloodType + "" + healthInsurance + "" + location;
        }
        public static bool Delete(Pacient pacient)
        {
            if (pacient != null && pacients.Count() > 0)
                return pacients.Remove(pacient);
            return false;
        }
        public static List<Pacient> Search(string PacientSearch)
        {
            PacientSearch = PacientSearch.ToLower();
            List<Pacient> PacientFound = new List<Pacient>();

            foreach (Pacient e in Pacient.pacients)
            {
                if (e.Name.ToLower().Contains(PacientSearch) || e.Surname.ToLower().Contains(PacientSearch) || e.HealthInsurance.ToString().Contains(PacientSearch) ||
                    e.Contact.ToString().Contains(PacientSearch) || e.BloodType.ToString().Contains(PacientSearch) || e.DateofBirth.ToString().Contains(PacientSearch) || e.Document.ToString().Contains(PacientSearch) ||
                    e.DocumentNumber.ToString().Contains(PacientSearch) || e.Gender.ToLower().Contains(PacientSearch) || e.DocumentNumber.ToString() == PacientSearch || e.Location.ToString().ToLower().Contains(PacientSearch))
                    PacientFound.Add(e);
            }

            return PacientFound;
        }
            #endregion

            #region Builders
            public Pacient()
        {
            name = "";
            surname = "";
            dateofBirth = new DateTime(1900, 1, 1);
            gender = "";
            documentNumber = 0;
            contact = null;
            document = null;
            bloodType = null;
            healthInsurance = null;
            location = null;
        }
        public Pacient(string name, string surname, DateTime dateofBirth, string gender, int documentNumber, Contact contact, Document document, BloodType bloodType, HealthInsurance healthInsurance, Location location)
        {
            this.name = name;
            this.surname = surname;
            this.dateofBirth = dateofBirth;
            this.gender = gender;
            this.documentNumber = documentNumber;
            this.contact = contact;
            this.document = document;
            this.bloodType = bloodType;
            this.healthInsurance = healthInsurance;
            this.location = location;
        }

        #endregion
    }
}
