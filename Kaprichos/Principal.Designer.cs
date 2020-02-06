namespace Kaprichos
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.botoncajero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonminimizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonconfiguracion = new System.Windows.Forms.Button();
            this.botonsalir = new System.Windows.Forms.Button();
            this.botoncorte = new System.Windows.Forms.Button();
            this.botoninventario = new System.Windows.Forms.Button();
            this.botonproductos = new System.Windows.Forms.Button();
            this.botonventas = new System.Windows.Forms.Button();
            this.botonclientes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.botoncajero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.botonminimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 64);
            this.panel1.TabIndex = 0;
            // 
            // botoncajero
            // 
            this.botoncajero.BackColor = System.Drawing.Color.White;
            this.botoncajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoncajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.botoncajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncajero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncajero.Image = ((System.Drawing.Image)(resources.GetObject("botoncajero.Image")));
            this.botoncajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botoncajero.Location = new System.Drawing.Point(1131, 26);
            this.botoncajero.Name = "botoncajero";
            this.botoncajero.Size = new System.Drawing.Size(171, 28);
            this.botoncajero.TabIndex = 5;
            this.botoncajero.Text = "Kaprichos";
            this.botoncajero.UseVisualStyleBackColor = false;
            this.botoncajero.Click += new System.EventHandler(this.botoncajero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1176, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cajero actual:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-20, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.botonminimizar.Location = new System.Drawing.Point(1323, -1);
            this.botonminimizar.Name = "botonminimizar";
            this.botonminimizar.Size = new System.Drawing.Size(36, 30);
            this.botonminimizar.TabIndex = 1;
            this.botonminimizar.UseVisualStyleBackColor = false;
            this.botonminimizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.botonconfiguracion);
            this.panel2.Controls.Add(this.botonsalir);
            this.panel2.Controls.Add(this.botoncorte);
            this.panel2.Controls.Add(this.botoninventario);
            this.panel2.Controls.Add(this.botonproductos);
            this.panel2.Controls.Add(this.botonventas);
            this.panel2.Controls.Add(this.botonclientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 42);
            this.panel2.TabIndex = 1;
            // 
            // botonconfiguracion
            // 
            this.botonconfiguracion.BackColor = System.Drawing.Color.White;
            this.botonconfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonconfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.botonconfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonconfiguracion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonconfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("botonconfiguracion.Image")));
            this.botonconfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonconfiguracion.Location = new System.Drawing.Point(564, 4);
            this.botonconfiguracion.Name = "botonconfiguracion";
            this.botonconfiguracion.Size = new System.Drawing.Size(124, 33);
            this.botonconfiguracion.TabIndex = 7;
            this.botonconfiguracion.Text = "Configuración";
            this.botonconfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonconfiguracion.UseVisualStyleBackColor = false;
            this.botonconfiguracion.Click += new System.EventHandler(this.botonconfiguracion_Click);
            // 
            // botonsalir
            // 
            this.botonsalir.BackColor = System.Drawing.Color.White;
            this.botonsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.botonsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonsalir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonsalir.Image = ((System.Drawing.Image)(resources.GetObject("botonsalir.Image")));
            this.botonsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonsalir.Location = new System.Drawing.Point(1288, 6);
            this.botonsalir.Name = "botonsalir";
            this.botonsalir.Size = new System.Drawing.Size(66, 28);
            this.botonsalir.TabIndex = 6;
            this.botonsalir.Text = "Salir";
            this.botonsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonsalir.UseVisualStyleBackColor = false;
            this.botonsalir.Click += new System.EventHandler(this.botonsalir_Click);
            // 
            // botoncorte
            // 
            this.botoncorte.BackColor = System.Drawing.Color.White;
            this.botoncorte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoncorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.botoncorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncorte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncorte.Image = ((System.Drawing.Image)(resources.GetObject("botoncorte.Image")));
            this.botoncorte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botoncorte.Location = new System.Drawing.Point(466, 4);
            this.botoncorte.Name = "botoncorte";
            this.botoncorte.Size = new System.Drawing.Size(92, 33);
            this.botoncorte.TabIndex = 4;
            this.botoncorte.Text = "F5 Corte";
            this.botoncorte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botoncorte.UseVisualStyleBackColor = false;
            this.botoncorte.Click += new System.EventHandler(this.botoncorte_Click);
            // 
            // botoninventario
            // 
            this.botoninventario.BackColor = System.Drawing.Color.White;
            this.botoninventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoninventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.botoninventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoninventario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoninventario.Image = ((System.Drawing.Image)(resources.GetObject("botoninventario.Image")));
            this.botoninventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botoninventario.Location = new System.Drawing.Point(345, 4);
            this.botoninventario.Name = "botoninventario";
            this.botoninventario.Size = new System.Drawing.Size(115, 33);
            this.botoninventario.TabIndex = 3;
            this.botoninventario.Text = "F4 Inventario";
            this.botoninventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botoninventario.UseVisualStyleBackColor = false;
            this.botoninventario.Click += new System.EventHandler(this.botoninventario_Click);
            // 
            // botonproductos
            // 
            this.botonproductos.BackColor = System.Drawing.Color.White;
            this.botonproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.botonproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonproductos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonproductos.Image = ((System.Drawing.Image)(resources.GetObject("botonproductos.Image")));
            this.botonproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonproductos.Location = new System.Drawing.Point(224, 4);
            this.botonproductos.Name = "botonproductos";
            this.botonproductos.Size = new System.Drawing.Size(115, 33);
            this.botonproductos.TabIndex = 2;
            this.botonproductos.Text = "F3 Productos";
            this.botonproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonproductos.UseVisualStyleBackColor = false;
            this.botonproductos.Click += new System.EventHandler(this.button4_Click);
            // 
            // botonventas
            // 
            this.botonventas.BackColor = System.Drawing.Color.White;
            this.botonventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.botonventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonventas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonventas.Image = ((System.Drawing.Image)(resources.GetObject("botonventas.Image")));
            this.botonventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonventas.Location = new System.Drawing.Point(4, 4);
            this.botonventas.Name = "botonventas";
            this.botonventas.Size = new System.Drawing.Size(104, 33);
            this.botonventas.TabIndex = 1;
            this.botonventas.Text = "F1 Ventas";
            this.botonventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonventas.UseVisualStyleBackColor = false;
            this.botonventas.Click += new System.EventHandler(this.botonventas_Click);
            // 
            // botonclientes
            // 
            this.botonclientes.BackColor = System.Drawing.Color.White;
            this.botonclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.botonclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonclientes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonclientes.Image = ((System.Drawing.Image)(resources.GetObject("botonclientes.Image")));
            this.botonclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonclientes.Location = new System.Drawing.Point(114, 4);
            this.botonclientes.Name = "botonclientes";
            this.botonclientes.Size = new System.Drawing.Size(104, 33);
            this.botonclientes.TabIndex = 0;
            this.botonclientes.Text = "F2 Clientes";
            this.botonclientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonclientes.UseVisualStyleBackColor = false;
            this.botonclientes.Click += new System.EventHandler(this.botonclientes_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 741);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1360, 27);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1291, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kaprichos Punto de Venta (2019)";
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // panelprincipal
            // 
            this.panelprincipal.BackColor = System.Drawing.Color.White;
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprincipal.Location = new System.Drawing.Point(0, 106);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(1360, 635);
            this.panelprincipal.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaprichos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonminimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonclientes;
        private System.Windows.Forms.Button botonventas;
        private System.Windows.Forms.Button botonproductos;
        private System.Windows.Forms.Button botoninventario;
        private System.Windows.Forms.Button botoncorte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botoncajero;
        private System.Windows.Forms.Button botonsalir;
        private System.Windows.Forms.Button botonconfiguracion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Panel panelprincipal;
    }
}

