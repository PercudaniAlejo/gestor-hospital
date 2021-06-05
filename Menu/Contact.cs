﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class Contact
    {
        #region MV       
        private string mail;
        private int numberPhone;
        private int tutorsPhone;
        private static List<Contact> contacts = new List<Contact>();
        #endregion
        #region Properties
        public string Mail { get => mail; set => mail = value; }
        public int NumberPhone { get => numberPhone; set => numberPhone = value; }
        public int TutorsPhone { get => tutorsPhone; set => tutorsPhone = value; }
        public static List<Contact> Contacts { get => contacts; set => contacts = value; }
        #endregion
        #region Methods
        public override string ToString()
        {
            return mail + "" + numberPhone + "" + tutorsPhone;
        }

        #endregion
        #region Builders
        public Contact()
        {
            mail = "";
            numberPhone = 0;
            tutorsPhone = 0;
        }
        public Contact(string mail, int numberPhone, int tutorsPhone)
        {
            this.mail = mail;
            this.numberPhone = numberPhone;
            this.tutorsPhone = tutorsPhone;
        }
        #endregion
    }
}
