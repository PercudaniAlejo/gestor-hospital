
namespace Menu
{
    partial class NewConsultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConsultation));
            this.Lbldescrip = new System.Windows.Forms.Label();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cmbdoctor = new System.Windows.Forms.ComboBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.dtpCD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbldescrip
            // 
            this.Lbldescrip.AutoSize = true;
            this.Lbldescrip.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbldescrip.Location = new System.Drawing.Point(206, 11);
            this.Lbldescrip.Name = "Lbldescrip";
            this.Lbldescrip.Size = new System.Drawing.Size(63, 13);
            this.Lbldescrip.TabIndex = 0;
            this.Lbldescrip.Text = "Descripcion";
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(209, 29);
            this.txtdescrip.Multiline = true;
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(189, 99);
            this.txtdescrip.TabIndex = 1;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDoctor.Location = new System.Drawing.Point(12, 11);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "Doctor";
            // 
            // cmbdoctor
            // 
            this.cmbdoctor.FormattingEnabled = true;
            this.cmbdoctor.Location = new System.Drawing.Point(15, 28);
            this.cmbdoctor.Name = "cmbdoctor";
            this.cmbdoctor.Size = new System.Drawing.Size(164, 21);
            this.cmbdoctor.TabIndex = 3;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPaciente.Location = new System.Drawing.Point(12, 52);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPaciente.TabIndex = 4;
            this.lblPaciente.Text = "Paciente";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(15, 68);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(164, 21);
            this.cmbPaciente.TabIndex = 5;
            // 
            // dtpCD
            // 
            this.dtpCD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCD.Location = new System.Drawing.Point(15, 108);
            this.dtpCD.Name = "dtpCD";
            this.dtpCD.Size = new System.Drawing.Size(164, 20);
            this.dtpCD.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consultation date";
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnconfirm.BackgroundImage = global::Menu.Properties.Resources.Tick;
            this.btnconfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnconfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfirm.FlatAppearance.BorderSize = 0;
            this.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirm.Location = new System.Drawing.Point(14, 136);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(30, 30);
            this.btnconfirm.TabIndex = 8;
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.BackgroundImage = global::Menu.Properties.Resources.Delete;
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Location = new System.Drawing.Point(50, 136);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(30, 30);
            this.btncancel.TabIndex = 9;
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // NewConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 174);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCD);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.cmbdoctor);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.txtdescrip);
            this.Controls.Add(this.Lbldescrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(421, 213);
            this.MinimumSize = new System.Drawing.Size(421, 213);
            this.Name = "NewConsultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewConsultation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbldescrip;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cmbdoctor;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.DateTimePicker dtpCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btncancel;
    }
}