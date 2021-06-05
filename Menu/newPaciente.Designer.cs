
namespace Menu
{
    partial class newPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.cmbBloodType = new System.Windows.Forms.ComboBox();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.nudDocumentNum = new System.Windows.Forms.NumericUpDown();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.dateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnHealtInsurence = new System.Windows.Forms.Button();
            this.btnocationPacient = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDocumentNum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(25, 65);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(80, 62);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(178, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(25, 100);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Date of birth";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(25, 133);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(57, 13);
            this.lblBloodType.TabIndex = 7;
            this.lblBloodType.Text = "Blood type";
            // 
            // cmbBloodType
            // 
            this.cmbBloodType.FormattingEnabled = true;
            this.cmbBloodType.Location = new System.Drawing.Point(97, 130);
            this.cmbBloodType.Name = "cmbBloodType";
            this.cmbBloodType.Size = new System.Drawing.Size(161, 21);
            this.cmbBloodType.TabIndex = 8;
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Location = new System.Drawing.Point(25, 172);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(79, 13);
            this.lblDocumentType.TabIndex = 10;
            this.lblDocumentType.Text = "Document type";
            // 
            // nudDocumentNum
            // 
            this.nudDocumentNum.Location = new System.Drawing.Point(125, 207);
            this.nudDocumentNum.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudDocumentNum.Name = "nudDocumentNum";
            this.nudDocumentNum.Size = new System.Drawing.Size(133, 20);
            this.nudDocumentNum.TabIndex = 13;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(25, 209);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(94, 13);
            this.lblDocumentNumber.TabIndex = 12;
            this.lblDocumentNumber.Text = "Document number";
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Location = new System.Drawing.Point(110, 172);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(148, 21);
            this.cmbDocumentType.TabIndex = 14;
            // 
            // dateDateOfBirth
            // 
            this.dateDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateOfBirth.Location = new System.Drawing.Point(96, 100);
            this.dateDateOfBirth.Name = "dateDateOfBirth";
            this.dateDateOfBirth.Size = new System.Drawing.Size(162, 20);
            this.dateDateOfBirth.TabIndex = 15;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(28, 245);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(92, 29);
            this.btnAddContact.TabIndex = 16;
            this.btnAddContact.Text = "Add contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            // 
            // btnHealtInsurence
            // 
            this.btnHealtInsurence.Location = new System.Drawing.Point(138, 245);
            this.btnHealtInsurence.Name = "btnHealtInsurence";
            this.btnHealtInsurence.Size = new System.Drawing.Size(120, 29);
            this.btnHealtInsurence.TabIndex = 17;
            this.btnHealtInsurence.Text = "Add Healt Insurence";
            this.btnHealtInsurence.UseVisualStyleBackColor = true;
            // 
            // btnocationPacient
            // 
            this.btnocationPacient.Location = new System.Drawing.Point(66, 292);
            this.btnocationPacient.Name = "btnocationPacient";
            this.btnocationPacient.Size = new System.Drawing.Size(126, 29);
            this.btnocationPacient.TabIndex = 18;
            this.btnocationPacient.Text = "Add Location Pacient";
            this.btnocationPacient.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(28, 366);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 35);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(147, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 35);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // newPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnocationPacient);
            this.Controls.Add(this.btnHealtInsurence);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.dateDateOfBirth);
            this.Controls.Add(this.cmbDocumentType);
            this.Controls.Add(this.nudDocumentNum);
            this.Controls.Add(this.lblDocumentNumber);
            this.Controls.Add(this.lblDocumentType);
            this.Controls.Add(this.cmbBloodType);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.MaximumSize = new System.Drawing.Size(297, 489);
            this.MinimumSize = new System.Drawing.Size(297, 489);
            this.Name = "newPaciente";
            this.Text = "newPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.nudDocumentNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cmbBloodType;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.NumericUpDown nudDocumentNum;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.DateTimePicker dateDateOfBirth;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnHealtInsurence;
        private System.Windows.Forms.Button btnocationPacient;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}