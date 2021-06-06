
namespace Menu
{
    partial class addContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addContact));
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.nudNP = new System.Windows.Forms.NumericUpDown();
            this.lblNumberPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNP2 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMother = new System.Windows.Forms.CheckBox();
            this.checkBoxFather = new System.Windows.Forms.CheckBox();
            this.checkBoxTutor = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNP2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // nudNP
            // 
            this.nudNP.Location = new System.Drawing.Point(12, 76);
            this.nudNP.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudNP.Name = "nudNP";
            this.nudNP.Size = new System.Drawing.Size(189, 20);
            this.nudNP.TabIndex = 2;
            // 
            // lblNumberPhone
            // 
            this.lblNumberPhone.AutoSize = true;
            this.lblNumberPhone.Location = new System.Drawing.Point(9, 60);
            this.lblNumberPhone.Name = "lblNumberPhone";
            this.lblNumberPhone.Size = new System.Drawing.Size(78, 13);
            this.lblNumberPhone.TabIndex = 3;
            this.lblNumberPhone.Text = "Number Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Phone";
            // 
            // nudNP2
            // 
            this.nudNP2.Location = new System.Drawing.Point(7, 57);
            this.nudNP2.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudNP2.Name = "nudNP2";
            this.nudNP2.Size = new System.Drawing.Size(189, 20);
            this.nudNP2.TabIndex = 4;
            // 
            // checkBoxMother
            // 
            this.checkBoxMother.AutoSize = true;
            this.checkBoxMother.Location = new System.Drawing.Point(7, 7);
            this.checkBoxMother.Name = "checkBoxMother";
            this.checkBoxMother.Size = new System.Drawing.Size(59, 17);
            this.checkBoxMother.TabIndex = 10;
            this.checkBoxMother.Text = "Mother";
            this.checkBoxMother.UseVisualStyleBackColor = true;
            this.checkBoxMother.CheckedChanged += new System.EventHandler(this.checkBoxMother_CheckedChanged);
            // 
            // checkBoxFather
            // 
            this.checkBoxFather.AutoSize = true;
            this.checkBoxFather.Location = new System.Drawing.Point(72, 7);
            this.checkBoxFather.Name = "checkBoxFather";
            this.checkBoxFather.Size = new System.Drawing.Size(56, 17);
            this.checkBoxFather.TabIndex = 11;
            this.checkBoxFather.Text = "Father";
            this.checkBoxFather.UseVisualStyleBackColor = true;
            this.checkBoxFather.CheckedChanged += new System.EventHandler(this.checkBoxFather_CheckedChanged);
            // 
            // checkBoxTutor
            // 
            this.checkBoxTutor.AutoSize = true;
            this.checkBoxTutor.Location = new System.Drawing.Point(134, 7);
            this.checkBoxTutor.Name = "checkBoxTutor";
            this.checkBoxTutor.Size = new System.Drawing.Size(51, 17);
            this.checkBoxTutor.TabIndex = 12;
            this.checkBoxTutor.Text = "Tutor";
            this.checkBoxTutor.UseVisualStyleBackColor = true;
            this.checkBoxTutor.CheckedChanged += new System.EventHandler(this.checkBoxTutor_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::Menu.Properties.Resources.Delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Location = new System.Drawing.Point(50, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 30);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackgroundImage = global::Menu.Properties.Resources.Tick;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Location = new System.Drawing.Point(14, 207);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(30, 30);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxTutor);
            this.panel1.Controls.Add(this.checkBoxFather);
            this.panel1.Controls.Add(this.checkBoxMother);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudNP2);
            this.panel1.Location = new System.Drawing.Point(7, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 90);
            this.panel1.TabIndex = 23;
            // 
            // addContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblNumberPhone);
            this.Controls.Add(this.nudNP);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(228, 297);
            this.Name = "addContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Contact";
            this.Load += new System.EventHandler(this.addContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNP2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.NumericUpDown nudNP;
        private System.Windows.Forms.Label lblNumberPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNP2;
        private System.Windows.Forms.CheckBox checkBoxMother;
        private System.Windows.Forms.CheckBox checkBoxFather;
        private System.Windows.Forms.CheckBox checkBoxTutor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel1;
    }
}