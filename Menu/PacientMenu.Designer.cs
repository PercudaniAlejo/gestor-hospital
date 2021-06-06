
namespace Menu
{
    partial class PacientMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientMenu));
            this.dgvPacient = new System.Windows.Forms.DataGridView();
            this.lblFilterPacient = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnFilterPacient = new System.Windows.Forms.Button();
            this.btnNewPacient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacient
            // 
            this.dgvPacient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacient.Location = new System.Drawing.Point(12, 65);
            this.dgvPacient.Name = "dgvPacient";
            this.dgvPacient.Size = new System.Drawing.Size(499, 299);
            this.dgvPacient.TabIndex = 1;
            // 
            // lblFilterPacient
            // 
            this.lblFilterPacient.Location = new System.Drawing.Point(121, 28);
            this.lblFilterPacient.Name = "lblFilterPacient";
            this.lblFilterPacient.Size = new System.Drawing.Size(271, 20);
            this.lblFilterPacient.TabIndex = 7;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.BackgroundImage = global::Menu.Properties.Resources.biggarbagebin_121980;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(48, 370);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(30, 30);
            this.btndelete.TabIndex = 10;
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.BackgroundImage = global::Menu.Properties.Resources.edit_modify_icon_149489;
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Location = new System.Drawing.Point(12, 370);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(30, 30);
            this.btnedit.TabIndex = 9;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnFilterPacient
            // 
            this.btnFilterPacient.BackColor = System.Drawing.Color.Transparent;
            this.btnFilterPacient.BackgroundImage = global::Menu.Properties.Resources.Search;
            this.btnFilterPacient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilterPacient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterPacient.FlatAppearance.BorderSize = 0;
            this.btnFilterPacient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterPacient.Location = new System.Drawing.Point(398, 25);
            this.btnFilterPacient.Name = "btnFilterPacient";
            this.btnFilterPacient.Size = new System.Drawing.Size(25, 25);
            this.btnFilterPacient.TabIndex = 8;
            this.btnFilterPacient.UseVisualStyleBackColor = false;
            this.btnFilterPacient.Click += new System.EventHandler(this.btnFilterPacient_Click);
            // 
            // btnNewPacient
            // 
            this.btnNewPacient.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPacient.BackgroundImage = global::Menu.Properties.Resources.Add_Pacient;
            this.btnNewPacient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPacient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPacient.FlatAppearance.BorderSize = 0;
            this.btnNewPacient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPacient.Location = new System.Drawing.Point(470, 370);
            this.btnNewPacient.Name = "btnNewPacient";
            this.btnNewPacient.Size = new System.Drawing.Size(30, 30);
            this.btnNewPacient.TabIndex = 0;
            this.btnNewPacient.UseVisualStyleBackColor = false;
            this.btnNewPacient.Click += new System.EventHandler(this.btnNewPacient_Click);
            // 
            // PacientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 406);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnFilterPacient);
            this.Controls.Add(this.lblFilterPacient);
            this.Controls.Add(this.dgvPacient);
            this.Controls.Add(this.btnNewPacient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(541, 445);
            this.MinimumSize = new System.Drawing.Size(541, 445);
            this.Name = "PacientMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacient Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPacient;
        private System.Windows.Forms.DataGridView dgvPacient;
        private System.Windows.Forms.Button btnFilterPacient;
        private System.Windows.Forms.TextBox lblFilterPacient;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
    }
}