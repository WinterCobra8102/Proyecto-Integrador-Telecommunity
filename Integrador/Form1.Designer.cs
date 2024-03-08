namespace Integrador
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic_logo_AdminPanel = new System.Windows.Forms.PictureBox();
            this.lbl_name_form_admin = new System.Windows.Forms.Label();
            this.pnl_title_admin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_AdminPanel)).BeginInit();
            this.pnl_title_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_logo_AdminPanel
            // 
            this.pic_logo_AdminPanel.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo_AdminPanel.Image")));
            this.pic_logo_AdminPanel.Location = new System.Drawing.Point(0, 0);
            this.pic_logo_AdminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo_AdminPanel.Name = "pic_logo_AdminPanel";
            this.pic_logo_AdminPanel.Size = new System.Drawing.Size(209, 132);
            this.pic_logo_AdminPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo_AdminPanel.TabIndex = 0;
            this.pic_logo_AdminPanel.TabStop = false;
            // 
            // lbl_name_form_admin
            // 
            this.lbl_name_form_admin.AutoSize = true;
            this.lbl_name_form_admin.Font = new System.Drawing.Font("Bookman Old Style", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_form_admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name_form_admin.Location = new System.Drawing.Point(206, 40);
            this.lbl_name_form_admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name_form_admin.Name = "lbl_name_form_admin";
            this.lbl_name_form_admin.Size = new System.Drawing.Size(386, 56);
            this.lbl_name_form_admin.TabIndex = 1;
            this.lbl_name_form_admin.Text = "TeleCommunity";
            // 
            // pnl_title_admin
            // 
            this.pnl_title_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(229)))));
            this.pnl_title_admin.Controls.Add(this.lbl_name_form_admin);
            this.pnl_title_admin.Controls.Add(this.pic_logo_AdminPanel);
            this.pnl_title_admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title_admin.Location = new System.Drawing.Point(0, 0);
            this.pnl_title_admin.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_title_admin.Name = "pnl_title_admin";
            this.pnl_title_admin.Size = new System.Drawing.Size(1300, 136);
            this.pnl_title_admin.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.pnl_title_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_AdminPanel)).EndInit();
            this.pnl_title_admin.ResumeLayout(false);
            this.pnl_title_admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo_AdminPanel;
        private System.Windows.Forms.Label lbl_name_form_admin;
        private System.Windows.Forms.Panel pnl_title_admin;
    }
}

