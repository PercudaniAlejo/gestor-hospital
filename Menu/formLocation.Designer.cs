
namespace Menu
{
    partial class formLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLocation));
            this.lblDateOfArrival = new System.Windows.Forms.Label();
            this.dtpDateOfArrival = new System.Windows.Forms.DateTimePicker();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.dgvloc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloc)).BeginInit();
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::Menu.Properties.Resources.Delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(59, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 30);
            this.btnCancel.TabIndex = 7;
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
            this.btnConfirm.Location = new System.Drawing.Point(16, 96);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(30, 30);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(316, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(235, 277);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 39;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // dgvloc
            // 
            this.dgvloc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloc.Location = new System.Drawing.Point(235, 13);
            this.dgvloc.Name = "dgvloc";
            this.dgvloc.Size = new System.Drawing.Size(436, 245);
            this.dgvloc.TabIndex = 38;
            // 
            // formLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 312);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dgvloc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.dtpDateOfArrival);
            this.Controls.Add(this.lblDateOfArrival);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(707, 351);
            this.MinimumSize = new System.Drawing.Size(707, 351);
            this.Name = "formLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location";
            ((System.ComponentModel.ISupportInitialize)(this.dgvloc)).EndInit();
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dgvloc;
    }
}