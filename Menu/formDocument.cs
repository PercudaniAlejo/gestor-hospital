using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace Menu
{
    public partial class formDocument : Form
    {
        formDocument obj;
        #region EVENTS
        public formDocument()
        {
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Save();
            Clear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region METHODS
        private void Save()
        {
            if (obj == null)
            {
                formDocument newDocument = new Document(txtDocumentType.Text);
                formDocument.DocTypes.Add(newDocument);
            }
            else{
                obj.doctype = txtDocumentType.Text;
            }
        }
        private void Clear() {
            txtDocumentType.Text = "";
        }

        #endregion

    }
}
