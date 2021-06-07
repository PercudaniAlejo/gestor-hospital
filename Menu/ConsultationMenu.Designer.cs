
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationMenu));
            this.dgvconsult = new System.Windows.Forms.DataGridView();
            this.txtbuscon = new System.Windows.Forms.TextBox();
            this.btnbuscon = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.txtbuscon.Location = new System.Drawing.Point(113, 25);
            this.txtbuscon.Name = "txtbuscon";
            this.txtbuscon.Size = new System.Drawing.Size(247, 20);
            this.txtbuscon.TabIndex = 1;
            // 
            // btnbuscon
            // 
            this.btnbuscon.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscon.BackgroundImage = global::Menu.Properties.Resources.Search;
            this.btnbuscon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscon.FlatAppearance.BorderSize = 0;
            this.btnbuscon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscon.Location = new System.Drawing.Point(366, 19);
            this.btnbuscon.Name = "btnbuscon";
            this.btnbuscon.Size = new System.Drawing.Size(30, 30);
            this.btnbuscon.TabIndex = 2;
            this.btnbuscon.UseVisualStyleBackColor = false;
            this.btnbuscon.Click += new System.EventHandler(this.btnbuscon_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.BackgroundImage = global::Menu.Properties.Resources.edit_modify_icon_149489;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(12, 216);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(30, 30);
            this.btnModify.TabIndex = 3;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::Menu.Properties.Resources.biggarbagebin_121980;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(48, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.BackgroundImage = global::Menu.Properties.Resources._;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(480, 216);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(30, 30);
            this.btnadd.TabIndex = 5;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // ConsultationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 254);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnbuscon);
            this.Controls.Add(this.txtbuscon);
            this.Controls.Add(this.dgvconsult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(542, 293);
            this.MinimumSize = new System.Drawing.Size(542, 293);
            this.Name = "ConsultationMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultationMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvconsult;
        private System.Windows.Forms.TextBox txtbuscon;
        private System.Windows.Forms.Button btnbuscon;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnadd;
    }
}