﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
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
        #endregion
        #region Methods
        public override string ToString()
        {
            return name + "" + surname + "" + dateofBirth.ToShortDateString() + "" + gender + "" + contact + "" + document + "" + documentNumber;
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
        }
        public Pacient(string name, string surname, DateTime dateofBirth, string gender, int documentNumber, Contact contact, Document document)
        {
            this.name = name;
            this.surname = surname;
            this.dateofBirth = dateofBirth;
            this.gender = gender;
            this.documentNumber = documentNumber;
            this.contact = contact;
            this.document = document;
        }

        #endregion
    }
}