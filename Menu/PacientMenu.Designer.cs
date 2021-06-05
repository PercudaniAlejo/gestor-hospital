
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
            this.btnNewPacient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnFilterPacient = new System.Windows.Forms.Button();
            this.lblFilterPacient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPacient
            // 
            this.btnNewPacient.Location = new System.Drawing.Point(469, 402);
            this.btnNewPacient.Name = "btnNewPacient";
            this.btnNewPacient.Size = new System.Drawing.Size(100, 23);
            this.btnNewPacient.TabIndex = 0;
            this.btnNewPacient.Text = "New Pacient";
            this.btnNewPacient.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 299);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(122, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search";
            // 
            // btnFilterPacient
            // 
            this.btnFilterPacient.Location = new System.Drawing.Point(469, 31);
            this.btnFilterPacient.Name = "btnFilterPacient";
            this.btnFilterPacient.Size = new System.Drawing.Size(45, 21);
            this.btnFilterPacient.TabIndex = 8;
            this.btnFilterPacient.Text = "OK";
            this.btnFilterPacient.UseVisualStyleBackColor = true;
            // 
            // lblFilterPacient
            // 
            this.lblFilterPacient.Location = new System.Drawing.Point(179, 32);
            this.lblFilterPacient.Name = "lblFilterPacient";
            this.lblFilterPacient.Size = new System.Drawing.Size(271, 20);
            this.lblFilterPacient.TabIndex = 7;
            // 
            // PacientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 482);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnFilterPacient);
            this.Controls.Add(this.lblFilterPacient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNewPacient);
            this.Name = "PacientMenu";
            this.Text = "Pacient Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPacient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnFilterPacient;
        private System.Windows.Forms.TextBox lblFilterPacient;
    }
}