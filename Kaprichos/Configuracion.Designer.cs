namespace Kaprichos
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonventas = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 45);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.botonventas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 40);
            this.panel2.TabIndex = 1;
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
            this.botonventas.Location = new System.Drawing.Point(3, 3);
            this.botonventas.Name = "botonventas";
            this.botonventas.Size = new System.Drawing.Size(104, 33);
            this.botonventas.TabIndex = 2;
            this.botonventas.Text = "F1 Ventas";
            this.botonventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonventas.UseVisualStyleBackColor = false;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonventas;
    }
}