using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    class Contact
    {
        #region MV       
        private string mail;
        private int numberPhone;
        private int tutorsPhone;
        #endregion
        #region Properties
        public string Mail { get => mail; set => mail = value; }
        public int NumberPhone { get => numberPhone; set => numberPhone = value; }
        public int TutorsPhone { get => tutorsPhone; set => tutorsPhone = value; }
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
            this.mail = "";
            this.numberPhone = 0;
            this.tutorsPhone = 0;
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
