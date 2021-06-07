
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnl1mas18 = new System.Windows.Forms.Panel();
            this.txttutor = new System.Windows.Forms.TextBox();
            this.lbltutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNP2)).BeginInit();
            this.pnl1mas18.SuspendLayout();
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::Menu.Properties.Resources.Delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(14, 207);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(30, 30);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnl1mas18
            // 
            this.pnl1mas18.Controls.Add(this.txttutor);
            this.pnl1mas18.Controls.Add(this.lbltutor);
            this.pnl1mas18.Controls.Add(this.label1);
            this.pnl1mas18.Controls.Add(this.nudNP2);
            this.pnl1mas18.Location = new System.Drawing.Point(7, 108);
            this.pnl1mas18.Name = "pnl1mas18";
            this.pnl1mas18.Size = new System.Drawing.Size(205, 90);
            this.pnl1mas18.TabIndex = 23;
            // 
            // txttutor
            // 
            this.txttutor.Location = new System.Drawing.Point(5, 18);
            this.txttutor.Name = "txttutor";
            this.txttutor.Size = new System.Drawing.Size(189, 20);
            this.txttutor.TabIndex = 24;
            // 
            // lbltutor
            // 
            this.lbltutor.AutoSize = true;
            this.lbltutor.Location = new System.Drawing.Point(5, 2);
            this.lbltutor.Name = "lbltutor";
            this.lbltutor.Size = new System.Drawing.Size(61, 13);
            this.lbltutor.TabIndex = 24;
            this.lbltutor.Text = "Tutor name";
            // 
            // addContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 251);
            this.Controls.Add(this.pnl1mas18);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblNumberPhone);
            this.Controls.Add(this.nudNP);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(236, 290);
            this.MinimumSize = new System.Drawing.Size(236, 290);
            this.Name = "addContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Contact";
            this.Load += new System.EventHandler(this.addContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNP2)).EndInit();
            this.pnl1mas18.ResumeLayout(false);
            this.pnl1mas18.PerformLayout();
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnl1mas18;
        private System.Windows.Forms.TextBox txttutor;
        private System.Windows.Forms.Label lbltutor;
    }
}