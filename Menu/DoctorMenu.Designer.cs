
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewPacient = new System.Windows.Forms.Button();
            this.lblFilterDoc = new System.Windows.Forms.TextBox();
            this.btnFilterDoc = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 318);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnNewPacient
            // 
            this.btnNewPacient.Location = new System.Drawing.Point(434, 396);
            this.btnNewPacient.Name = "btnNewPacient";
            this.btnNewPacient.Size = new System.Drawing.Size(100, 23);
            this.btnNewPacient.TabIndex = 2;
            this.btnNewPacient.Text = "New Doctor";
            this.btnNewPacient.UseVisualStyleBackColor = true;
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
            this.btnFilterDoc.Location = new System.Drawing.Point(411, 21);
            this.btnFilterDoc.Name = "btnFilterDoc";
            this.btnFilterDoc.Size = new System.Drawing.Size(45, 21);
            this.btnFilterDoc.TabIndex = 5;
            this.btnFilterDoc.Text = "OK";
            this.btnFilterDoc.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(64, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search";
            // 
            // DoctorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 437);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnFilterDoc);
            this.Controls.Add(this.lblFilterDoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNewPacient);
            this.Name = "DoctorMenu";
            this.Text = "DoctorMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewPacient;
        private System.Windows.Forms.TextBox lblFilterDoc;
        private System.Windows.Forms.Button btnFilterDoc;
        private System.Windows.Forms.Label lblSearch;
    }
}