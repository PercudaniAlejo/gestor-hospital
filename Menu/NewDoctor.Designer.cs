
namespace Menu
{
    partial class NewDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDoctor));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.nudDocumentNum = new System.Windows.Forms.NumericUpDown();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbSpecialField = new System.Windows.Forms.ComboBox();
            this.lblSpecialField = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDocumentNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::Menu.Properties.Resources.Delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(61, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 30);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackgroundImage = global::Menu.Properties.Resources.Tick;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(15, 250);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(30, 30);
            this.btnConfirm.TabIndex = 36;
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // dateDateOfBirth
            // 
            this.dateDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateOfBirth.Location = new System.Drawing.Point(15, 103);
            this.dateDateOfBirth.Name = "dateDateOfBirth";
            this.dateDateOfBirth.Size = new System.Drawing.Size(192, 20);
            this.dateDateOfBirth.TabIndex = 32;
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Location = new System.Drawing.Point(15, 138);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(192, 21);
            this.cmbDocumentType.TabIndex = 31;
            // 
            // nudDocumentNum
            // 
            this.nudDocumentNum.Location = new System.Drawing.Point(15, 175);
            this.nudDocumentNum.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudDocumentNum.Name = "nudDocumentNum";
            this.nudDocumentNum.Size = new System.Drawing.Size(192, 20);
            this.nudDocumentNum.TabIndex = 30;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(12, 162);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(94, 13);
            this.lblDocumentNumber.TabIndex = 29;
            this.lblDocumentNumber.Text = "Document number";
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Location = new System.Drawing.Point(12, 126);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(79, 13);
            this.lblDocumentType.TabIndex = 28;
            this.lblDocumentType.Text = "Document type";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 87);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 13);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "Date of birth";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 48);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 24;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(15, 64);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(192, 20);
            this.txtSurname.TabIndex = 23;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 21;
            // 
            // cmbSpecialField
            // 
            this.cmbSpecialField.FormattingEnabled = true;
            this.cmbSpecialField.Location = new System.Drawing.Point(15, 214);
            this.cmbSpecialField.Name = "cmbSpecialField";
            this.cmbSpecialField.Size = new System.Drawing.Size(192, 21);
            this.cmbSpecialField.TabIndex = 39;
            // 
            // lblSpecialField
            // 
            this.lblSpecialField.AutoSize = true;
            this.lblSpecialField.Location = new System.Drawing.Point(12, 198);
            this.lblSpecialField.Name = "lblSpecialField";
            this.lblSpecialField.Size = new System.Drawing.Size(67, 13);
            this.lblSpecialField.TabIndex = 38;
            this.lblSpecialField.Text = "Special Field";
            // 
            // NewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 291);
            this.Controls.Add(this.cmbSpecialField);
            this.Controls.Add(this.lblSpecialField);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dateDateOfBirth);
            this.Controls.Add(this.cmbDocumentType);
            this.Controls.Add(this.nudDocumentNum);
            this.Controls.Add(this.lblDocumentNumber);
            this.Controls.Add(this.lblDocumentType);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(243, 330);
            this.MinimumSize = new System.Drawing.Size(243, 330);
            this.Name = "NewDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.nudDocumentNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dateDateOfBirth;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.NumericUpDown nudDocumentNum;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbSpecialField;
        private System.Windows.Forms.Label lblSpecialField;
    }
}