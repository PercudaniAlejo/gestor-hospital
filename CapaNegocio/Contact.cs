using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Contact
    {
        #region MV       
        private string mail;
        private int numberPhone;
        private int tutorsPhone;
        private bool mother;
        private bool father;
        private bool tutor;
        private static List<Contact> contacts = new List<Contact>();
        #endregion

        #region Properties
        public string Mail { get => mail; set => mail = value; }
        public int NumberPhone { get => numberPhone; set => numberPhone = value; }
        public int TutorsPhone { get => tutorsPhone; set => tutorsPhone = value; }
        public static List<Contact> Contacts { get => contacts; set => contacts = value; }
        public bool Mother { get => mother; set => mother = value; }
        public bool Father { get => father; set => father = value; }
        public bool Tutor { get => tutor; set => tutor = value; }

        #endregion

        #region Methods
        public override string ToString()
        {
            if (mother)
            {
              return mail + " " + numberPhone + " "+ "Mother" + " "+ tutorsPhone;
            }
            if (father)
            {
                return mail + " " + numberPhone + " " + "Father" + " " + tutorsPhone;
            }
            if (tutor)
            {
                return mail + " " + numberPhone + " " + "Tutor" + " " + tutorsPhone;
            }
            return mail + " " + numberPhone;
        }
        #endregion

        #region Builders
        public Contact()
        {
            mail = "";
            numberPhone = 0;
            tutorsPhone = 0;
            mother = false;
            father = false;
            tutor = false;
        }
        public Contact(string mail, int numberPhone, int tutorsPhone, bool mother, bool father, bool tutor)
        {
            this.mail = mail;
            this.numberPhone = numberPhone;
            this.tutorsPhone = tutorsPhone;
            this.mother = mother;
            this.father = father;
            this.tutor = tutor;
        }
        #endregion
    }
}
