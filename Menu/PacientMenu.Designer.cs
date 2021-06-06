
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFilterPacient = new System.Windows.Forms.TextBox();
            this.btnFilterPacient = new System.Windows.Forms.Button();
            this.btnNewPacient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 299);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblFilterPacient
            // 
            this.lblFilterPacient.Location = new System.Drawing.Point(121, 28);
            this.lblFilterPacient.Name = "lblFilterPacient";
            this.lblFilterPacient.Size = new System.Drawing.Size(271, 20);
            this.lblFilterPacient.TabIndex = 7;
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
            // 
            // PacientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 406);
            this.Controls.Add(this.btnFilterPacient);
            this.Controls.Add(this.lblFilterPacient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNewPacient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(541, 445);
            this.MinimumSize = new System.Drawing.Size(541, 445);
            this.Name = "PacientMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacient Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPacient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFilterPacient;
        private System.Windows.Forms.TextBox lblFilterPacient;
    }
}