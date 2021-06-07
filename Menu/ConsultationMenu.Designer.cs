
namespace Menu
{
    partial class ConsultationMenu
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
            this.dgvconsult = new System.Windows.Forms.DataGridView();
            this.txtbuscon = new System.Windows.Forms.TextBox();
            this.btnbuscon = new System.Windows.Forms.Button();
            this.btnConfirmcons = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvconsult
            // 
            this.dgvconsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsult.Location = new System.Drawing.Point(12, 60);
            this.dgvconsult.Name = "dgvconsult";
            this.dgvconsult.Size = new System.Drawing.Size(498, 150);
            this.dgvconsult.TabIndex = 0;
            // 
            // txtbuscon
            // 
            this.txtbuscon.Location = new System.Drawing.Point(85, 25);
            this.txtbuscon.Name = "txtbuscon";
            this.txtbuscon.Size = new System.Drawing.Size(219, 20);
            this.txtbuscon.TabIndex = 1;
            // 
            // btnbuscon
            // 
            this.btnbuscon.Location = new System.Drawing.Point(310, 23);
            this.btnbuscon.Name = "btnbuscon";
            this.btnbuscon.Size = new System.Drawing.Size(75, 23);
            this.btnbuscon.TabIndex = 2;
            this.btnbuscon.Text = "Buscar";
            this.btnbuscon.UseVisualStyleBackColor = true;
            // 
            // btnConfirmcons
            // 
            this.btnConfirmcons.Location = new System.Drawing.Point(12, 216);
            this.btnConfirmcons.Name = "btnConfirmcons";
            this.btnConfirmcons.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmcons.TabIndex = 3;
            this.btnConfirmcons.Text = "Confirm";
            this.btnConfirmcons.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(93, 216);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(435, 216);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // ConsultationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 279);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnConfirmcons);
            this.Controls.Add(this.btnbuscon);
            this.Controls.Add(this.txtbuscon);
            this.Controls.Add(this.dgvconsult);
            this.Name = "ConsultationMenu";
            this.Text = "ConsultationMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvconsult;
        private System.Windows.Forms.TextBox txtbuscon;
        private System.Windows.Forms.Button btnbuscon;
        private System.Windows.Forms.Button btnConfirmcons;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnadd;
    }
}