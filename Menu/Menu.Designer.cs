
namespace Menu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnPacient = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnDocument = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPacient
            // 
            this.btnPacient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacient.Location = new System.Drawing.Point(55, 12);
            this.btnPacient.Name = "btnPacient";
            this.btnPacient.Size = new System.Drawing.Size(99, 31);
            this.btnPacient.TabIndex = 0;
            this.btnPacient.Text = "Pacient";
            this.btnPacient.UseVisualStyleBackColor = true;
            this.btnPacient.Click += new System.EventHandler(this.btnPacient_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctor.Location = new System.Drawing.Point(55, 86);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(99, 31);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnDocument
            // 
            this.btnDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocument.Location = new System.Drawing.Point(55, 49);
            this.btnDocument.Name = "btnDocument";
            this.btnDocument.Size = new System.Drawing.Size(99, 31);
            this.btnDocument.TabIndex = 2;
            this.btnDocument.Text = "Document";
            this.btnDocument.UseVisualStyleBackColor = true;
            this.btnDocument.Click += new System.EventHandler(this.btnDocument_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsult.Location = new System.Drawing.Point(55, 121);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(99, 31);
            this.btnConsult.TabIndex = 3;
            this.btnConsult.Text = "Consultations";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 164);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.btnDocument);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnPacient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(227, 203);
            this.MinimumSize = new System.Drawing.Size(227, 203);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPacient;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnDocument;
        private System.Windows.Forms.Button btnConsult;
    }
}