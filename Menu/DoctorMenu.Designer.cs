
namespace Menu
{
    partial class DoctorMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMenu));
            this.dgvDoctorMenu = new System.Windows.Forms.DataGridView();
            this.lblFilterDoc = new System.Windows.Forms.TextBox();
            this.btnFilterDoc = new System.Windows.Forms.Button();
            this.btnNewPacient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoctorMenu
            // 
            this.dgvDoctorMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorMenu.Location = new System.Drawing.Point(12, 60);
            this.dgvDoctorMenu.Name = "dgvDoctorMenu";
            this.dgvDoctorMenu.Size = new System.Drawing.Size(520, 318);
            this.dgvDoctorMenu.TabIndex = 3;
            // 
            // lblFilterDoc
            // 
            this.lblFilterDoc.Location = new System.Drawing.Point(121, 22);
            this.lblFilterDoc.Name = "lblFilterDoc";
            this.lblFilterDoc.Size = new System.Drawing.Size(271, 20);
            this.lblFilterDoc.TabIndex = 4;
            // 
            // btnFilterDoc
            // 
            this.btnFilterDoc.BackColor = System.Drawing.Color.Transparent;
            this.btnFilterDoc.BackgroundImage = global::Menu.Properties.Resources.Search;
            this.btnFilterDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilterDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterDoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFilterDoc.FlatAppearance.BorderSize = 0;
            this.btnFilterDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDoc.Location = new System.Drawing.Point(398, 19);
            this.btnFilterDoc.Name = "btnFilterDoc";
            this.btnFilterDoc.Size = new System.Drawing.Size(25, 25);
            this.btnFilterDoc.TabIndex = 5;
            this.btnFilterDoc.UseVisualStyleBackColor = false;
            // 
            // btnNewPacient
            // 
            this.btnNewPacient.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPacient.BackgroundImage = global::Menu.Properties.Resources._;
            this.btnNewPacient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPacient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPacient.FlatAppearance.BorderSize = 0;
            this.btnNewPacient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPacient.Location = new System.Drawing.Point(502, 395);
            this.btnNewPacient.Name = "btnNewPacient";
            this.btnNewPacient.Size = new System.Drawing.Size(30, 30);
            this.btnNewPacient.TabIndex = 2;
            this.btnNewPacient.UseVisualStyleBackColor = false;
            this.btnNewPacient.Click += new System.EventHandler(this.btnNewPacient_Click);
            // 
            // DoctorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(546, 437);
            this.Controls.Add(this.btnFilterDoc);
            this.Controls.Add(this.lblFilterDoc);
            this.Controls.Add(this.dgvDoctorMenu);
            this.Controls.Add(this.btnNewPacient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctorMenu;
        private System.Windows.Forms.Button btnNewPacient;
        private System.Windows.Forms.TextBox lblFilterDoc;
        private System.Windows.Forms.Button btnFilterDoc;
    }
}