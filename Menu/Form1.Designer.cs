
namespace Menu
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnpacient = new System.Windows.Forms.Button();
            this.btndoctor = new System.Windows.Forms.Button();
            this.btndoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpacient
            // 
            this.btnpacient.Location = new System.Drawing.Point(64, 12);
            this.btnpacient.Name = "btnpacient";
            this.btnpacient.Size = new System.Drawing.Size(142, 33);
            this.btnpacient.TabIndex = 0;
            this.btnpacient.Text = "Pacient";
            this.btnpacient.UseVisualStyleBackColor = true;
            // 
            // btndoctor
            // 
            this.btndoctor.Location = new System.Drawing.Point(64, 51);
            this.btndoctor.Name = "btndoctor";
            this.btndoctor.Size = new System.Drawing.Size(142, 33);
            this.btndoctor.TabIndex = 1;
            this.btndoctor.Text = "Doctor";
            this.btndoctor.UseVisualStyleBackColor = true;
            // 
            // btndoc
            // 
            this.btndoc.Location = new System.Drawing.Point(64, 90);
            this.btndoc.Name = "btndoc";
            this.btndoc.Size = new System.Drawing.Size(142, 33);
            this.btndoc.TabIndex = 3;
            this.btndoc.Text = "Document";
            this.btndoc.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 150);
            this.Controls.Add(this.btndoc);
            this.Controls.Add(this.btndoctor);
            this.Controls.Add(this.btnpacient);
            this.MaximumSize = new System.Drawing.Size(284, 189);
            this.MinimumSize = new System.Drawing.Size(284, 189);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpacient;
        private System.Windows.Forms.Button btndoctor;
        private System.Windows.Forms.Button btndoc;
    }
}

