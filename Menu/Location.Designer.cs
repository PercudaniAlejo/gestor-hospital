﻿
namespace Menu
{
    partial class Location
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
            this.lblDateOfArrival = new System.Windows.Forms.Label();
            this.dtpDateOfArrival = new System.Windows.Forms.DateTimePicker();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDateOfArrival
            // 
            this.lblDateOfArrival.AutoSize = true;
            this.lblDateOfArrival.Location = new System.Drawing.Point(13, 13);
            this.lblDateOfArrival.Name = "lblDateOfArrival";
            this.lblDateOfArrival.Size = new System.Drawing.Size(76, 13);
            this.lblDateOfArrival.TabIndex = 0;
            this.lblDateOfArrival.Text = "Date Of Arrival";
            // 
            // dtpDateOfArrival
            // 
            this.dtpDateOfArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfArrival.Location = new System.Drawing.Point(96, 13);
            this.dtpDateOfArrival.Name = "dtpDateOfArrival";
            this.dtpDateOfArrival.Size = new System.Drawing.Size(100, 20);
            this.dtpDateOfArrival.TabIndex = 1;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(13, 40);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Room";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Location = new System.Drawing.Point(13, 67);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(26, 13);
            this.lblBed.TabIndex = 3;
            this.lblBed.Text = "Bed";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(96, 40);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 20);
            this.txtRoom.TabIndex = 4;
            // 
            // txtBed
            // 
            this.txtBed.Location = new System.Drawing.Point(96, 67);
            this.txtBed.MaxLength = 4;
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(100, 20);
            this.txtBed.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 105);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 135);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.dtpDateOfArrival);
            this.Controls.Add(this.lblDateOfArrival);
            this.Name = "Location";
            this.Text = "Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateOfArrival;
        private System.Windows.Forms.DateTimePicker dtpDateOfArrival;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtBed;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}