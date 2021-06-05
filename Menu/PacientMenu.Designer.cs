
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPacient
            // 
            this.btnNewPacient.Location = new System.Drawing.Point(12, 12);
            this.btnNewPacient.Name = "btnNewPacient";
            this.btnNewPacient.Size = new System.Drawing.Size(100, 23);
            this.btnNewPacient.TabIndex = 0;
            this.btnNewPacient.Text = "New Pacient";
            this.btnNewPacient.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // PacientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNewPacient);
            this.Name = "PacientMenu";
            this.Text = "Pacient Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewPacient;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}