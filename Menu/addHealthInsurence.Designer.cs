
namespace Menu
{
    partial class addHealthInsurence
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
            this.dateDueDate = new System.Windows.Forms.DateTimePicker();
            this.nudHealthInsurenceNum = new System.Windows.Forms.NumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthInsurenceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDueDate
            // 
            this.dateDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDueDate.Location = new System.Drawing.Point(96, 108);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(162, 20);
            this.dateDueDate.TabIndex = 27;
            // 
            // nudHealthInsurenceNum
            // 
            this.nudHealthInsurenceNum.Location = new System.Drawing.Point(125, 145);
            this.nudHealthInsurenceNum.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudHealthInsurenceNum.Name = "nudHealthInsurenceNum";
            this.nudHealthInsurenceNum.Size = new System.Drawing.Size(133, 20);
            this.nudHealthInsurenceNum.TabIndex = 25;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(25, 147);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 24;
            this.lblNumber.Text = "Number";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(25, 108);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 20;
            this.lblDueDate.Text = "Date Date";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(25, 73);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 19;
            this.lblPlan.Text = "Plan";
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(80, 70);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(178, 20);
            this.txtPlan.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(147, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 35);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(16, 235);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 35);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(66, 182);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(192, 20);
            this.txtType.TabIndex = 30;
            // 
            // addHealthInsurence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dateDueDate);
            this.Controls.Add(this.nudHealthInsurenceNum);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.txtPlan);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.MaximumSize = new System.Drawing.Size(295, 338);
            this.MinimumSize = new System.Drawing.Size(295, 338);
            this.Name = "addHealthInsurence";
            this.Text = "addHealthInsurence";
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthInsurenceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDueDate;
        private System.Windows.Forms.NumericUpDown nudHealthInsurenceNum;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtType;
    }
}