﻿using System;
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
        Document obj;
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
            
        }
        #endregion


        #region METHODS
        private void Save()
        {
            if (obj == null)
            {
                Document newDocument = new Document(txtDocumentType.Text);
                Document.DocTypes.Add(newDocument);
            }
            else{
                obj.Doctype = txtDocumentType.Text;
            }
        }
        private void Clear() {
            txtDocumentType.Text = "";
        }

        #endregion

    }
}
