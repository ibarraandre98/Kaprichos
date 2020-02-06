namespace Kaprichos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonminimizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.contra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonentrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.botonminimizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 34);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // botonminimizar
            // 
            this.botonminimizar.BackColor = System.Drawing.Color.Transparent;
            this.botonminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonminimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(115)))));
            this.botonminimizar.FlatAppearance.BorderSize = 0;
            this.botonminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonminimizar.Image = ((System.Drawing.Image)(resources.GetObject("botonminimizar.Image")));
            this.botonminimizar.Location = new System.Drawing.Point(362, 3);
            this.botonminimizar.Name = "botonminimizar";
            this.botonminimizar.Size = new System.Drawing.Size(27, 27);
            this.botonminimizar.TabIndex = 0;
            this.botonminimizar.UseVisualStyleBackColor = false;
            this.botonminimizar.Click += new System.EventHandler(this.botonminimizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kaprichos Punto de Venta - Acceso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(55, 182);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(27, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(55, 130);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 29);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // contra
            // 
            this.contra.BackColor = System.Drawing.Color.White;
            this.contra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.ForeColor = System.Drawing.Color.Black;
            this.contra.Location = new System.Drawing.Point(85, 184);
            this.contra.MaxLength = 20;
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(261, 27);
            this.contra.TabIndex = 1;
            this.contra.Enter += new System.EventHandler(this.contra_Enter);
            this.contra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(88, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(88, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña:";
            // 
            // botonentrar
            // 
            this.botonentrar.BackColor = System.Drawing.Color.White;
            this.botonentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonentrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.botonentrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonentrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonentrar.Image = ((System.Drawing.Image)(resources.GetObject("botonentrar.Image")));
            this.botonentrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonentrar.Location = new System.Drawing.Point(85, 230);
            this.botonentrar.Name = "botonentrar";
            this.botonentrar.Size = new System.Drawing.Size(104, 33);
            this.botonentrar.TabIndex = 2;
            this.botonentrar.Text = "Entrar";
            this.botonentrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonentrar.UseVisualStyleBackColor = false;
            this.botonentrar.Click += new System.EventHandler(this.botonentrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(242, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuario
            // 
            this.usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.usuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.usuario.FormattingEnabled = true;
            this.usuario.Location = new System.Drawing.Point(85, 131);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(261, 29);
            this.usuario.TabIndex = 0;
            this.usuario.SelectedIndexChanged += new System.EventHandler(this.usuario_SelectedIndexChanged);
            this.usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuario_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(392, 275);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonentrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonminimizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonentrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox usuario;
    }
}