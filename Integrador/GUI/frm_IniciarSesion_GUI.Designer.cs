namespace Integrador.GUI
{
    partial class frm_IniciarSesion_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IniciarSesion_GUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_logo_login = new System.Windows.Forms.PictureBox();
            this.btn_Acceder = new System.Windows.Forms.Button();
            this.lbl_bienbenida = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.img_user = new System.Windows.Forms.PictureBox();
            this.img_pass = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.pic_logo_login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 353);
            this.panel1.TabIndex = 2;
            // 
            // pic_logo_login
            // 
            this.pic_logo_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_logo_login.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo_login.Image")));
            this.pic_logo_login.Location = new System.Drawing.Point(0, 0);
            this.pic_logo_login.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo_login.Name = "pic_logo_login";
            this.pic_logo_login.Size = new System.Drawing.Size(307, 353);
            this.pic_logo_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo_login.TabIndex = 0;
            this.pic_logo_login.TabStop = false;
            // 
            // btn_Acceder
            // 
            this.btn_Acceder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acceder.ForeColor = System.Drawing.Color.Gray;
            this.btn_Acceder.Location = new System.Drawing.Point(371, 263);
            this.btn_Acceder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Acceder.Name = "btn_Acceder";
            this.btn_Acceder.Size = new System.Drawing.Size(439, 64);
            this.btn_Acceder.TabIndex = 16;
            this.btn_Acceder.Text = "Acceder";
            this.btn_Acceder.UseVisualStyleBackColor = true;
            this.btn_Acceder.Click += new System.EventHandler(this.btn_panel_admin_Click);
            // 
            // lbl_bienbenida
            // 
            this.lbl_bienbenida.AutoSize = true;
            this.lbl_bienbenida.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienbenida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_bienbenida.Location = new System.Drawing.Point(379, 31);
            this.lbl_bienbenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bienbenida.Name = "lbl_bienbenida";
            this.lbl_bienbenida.Size = new System.Drawing.Size(403, 35);
            this.lbl_bienbenida.TabIndex = 15;
            this.lbl_bienbenida.Text = "¡Bienvenido a Telecommunity!";
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pass.Location = new System.Drawing.Point(450, 198);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(360, 43);
            this.txt_pass.TabIndex = 12;
            this.txt_pass.Text = "CONTRASEÑA";
            // 
            // txt_user
            // 
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_user.Location = new System.Drawing.Point(450, 106);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(360, 43);
            this.txt_user.TabIndex = 11;
            this.txt_user.Text = "USUARIO";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(828, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(43, 28);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 18;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // img_user
            // 
            this.img_user.Image = ((System.Drawing.Image)(resources.GetObject("img_user.Image")));
            this.img_user.Location = new System.Drawing.Point(371, 102);
            this.img_user.Margin = new System.Windows.Forms.Padding(4);
            this.img_user.Name = "img_user";
            this.img_user.Size = new System.Drawing.Size(96, 47);
            this.img_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_user.TabIndex = 14;
            this.img_user.TabStop = false;
            // 
            // img_pass
            // 
            this.img_pass.Image = ((System.Drawing.Image)(resources.GetObject("img_pass.Image")));
            this.img_pass.Location = new System.Drawing.Point(371, 194);
            this.img_pass.Margin = new System.Windows.Forms.Padding(4);
            this.img_pass.Name = "img_pass";
            this.img_pass.Size = new System.Drawing.Size(96, 47);
            this.img_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_pass.TabIndex = 13;
            this.img_pass.TabStop = false;
            // 
            // frm_IniciarSesion_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 353);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_Acceder);
            this.Controls.Add(this.lbl_bienbenida);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.img_user);
            this.Controls.Add(this.img_pass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_IniciarSesion_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_IniciarSesion_GUI";
            this.Load += new System.EventHandler(this.frm_IniciarSesion_GUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_logo_login;
        private System.Windows.Forms.Button btn_Acceder;
        private System.Windows.Forms.Label lbl_bienbenida;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.PictureBox img_user;
        private System.Windows.Forms.PictureBox img_pass;
        private System.Windows.Forms.PictureBox btn_cerrar;
    }
}