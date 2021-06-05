
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
            this.btnPacient = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPacient
            // 
            this.btnPacient.Location = new System.Drawing.Point(12, 12);
            this.btnPacient.Name = "btnPacient";
            this.btnPacient.Size = new System.Drawing.Size(450, 23);
            this.btnPacient.TabIndex = 0;
            this.btnPacient.Text = "Pacient";
            this.btnPacient.UseVisualStyleBackColor = true;
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(12, 41);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(450, 23);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            // 
            // btnDocument
            // 
            this.btnDocument.Location = new System.Drawing.Point(12, 70);
            this.btnDocument.Name = "btnDocument";
            this.btnDocument.Size = new System.Drawing.Size(450, 23);
            this.btnDocument.TabIndex = 2;
            this.btnDocument.Text = "Document";
            this.btnDocument.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 105);
            this.Controls.Add(this.btnDocument);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnPacient);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPacient;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnDocument;
    }
}