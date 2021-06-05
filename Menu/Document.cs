using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    class Document
    {
        #region MV
        private string doctype;
        private static List<Document> docType = new List<Document>();
        #endregion
        #region Properties
        public string Doctype { get => doctype; set => doctype = value; }
        public static List<Document> DocType { get => docType; set => docType = value; }
        #endregion
        #region Methods
        public override string ToString()
        {
            return doctype;
        }
        #endregion
        #region Builders
        public Document()
        {
            doctype = "";
        }
        public Document(string doctype)
        {
            this.doctype = doctype;
        }
        #endregion
    }
}
