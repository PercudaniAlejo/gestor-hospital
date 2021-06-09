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
        private string tutor;
        private static List<Contact> contacts = new List<Contact>();
        static Contact obj;
        #endregion

        #region Properties
        public string Mail { get => mail; set => mail = value; }
        public int NumberPhone { get => numberPhone; set => numberPhone = value; }
        public int TutorsPhone { get => tutorsPhone; set => tutorsPhone = value; }
        public static List<Contact> Contacts { get => contacts; set => contacts = value; }
        public string Tutor { get => tutor; set => tutor = value; }
        public static Contact Obj { get => obj; set => obj = value; }

        #endregion

        #region Methods
        public override string ToString()
        {
            return mail + " " + numberPhone + " " + " " + tutor + " " + tutorsPhone;
        }
        #endregion

        #region Builders
        public Contact()
        {
            mail = "";
            numberPhone = 0;
            tutor = "";
            tutorsPhone = 0;
        }
        public Contact(string mail, int numberPhone, int tutorsPhone, string tutor)
        {
            this.mail = mail;
            this.numberPhone = numberPhone;
            this.tutorsPhone = tutorsPhone;
            this.tutor = tutor;
        }
        #endregion
    }
}
