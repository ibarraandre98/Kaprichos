using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Kaprichos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void PrivilegioUsuario()
        {
            if(Program.cargo != "Administrador" && Program.cargo != "Jefe")
            {
                botonclientes.Enabled = false;
                botonproductos.Enabled = false;
                botonconfiguracion.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivilegioUsuario();
            botoncajero.Text = Program.usuario;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(botoncajero,"Cambiar de cajero");
            tt.SetToolTip(botonsalir,"Salir del sistema");
            botonventas_Click(null,e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            botonproductos.Enabled = false;
            botonventas.Enabled = true;
            botonclientes.Enabled = true;
            botonconfiguracion.Enabled = true;
            botoninventario.Enabled = true;
            botoncorte.Enabled = true;
            AbrirFormEnPanel(new Productos());
        }

        private void botonsalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir del sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString(); ;
        }

        private void botoncajero_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cambiar de cajero?","Cambio",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Close();
            }
        }

        private void AbrirFormEnPanel(object formpanel)
        {
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            Form fp = formpanel as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.panelprincipal.Controls.Add(fp);
            this.panelprincipal.Tag = fp;
            fp.Show();
        }
        private void botonconfiguracion_Click(object sender, EventArgs e)
        {
            botonconfiguracion.Enabled = false;
            botonventas.Enabled = true;
            botonclientes.Enabled = true;
            botonproductos.Enabled = true;
            botoninventario.Enabled = true;
            botoncorte.Enabled = true;
            AbrirFormEnPanel(new Configuracion());
        }

        private void botonventas_Click(object sender, EventArgs e)
        {
            botonventas.Enabled = false;
            if(Program.cargo != "Administrador" && Program.cargo != "Jefe")
            {
                botoninventario.Enabled = true;
                botoncorte.Enabled = true;
            }
            else
            {
                botonconfiguracion.Enabled = true;
                botonclientes.Enabled = true;
                botonproductos.Enabled = true;
                botoninventario.Enabled = true;
                botoncorte.Enabled = true;
            }
            AbrirFormEnPanel(new Ventas());
        }

        private void botonclientes_Click(object sender, EventArgs e)
        {
            botonclientes.Enabled = false;
            botonventas.Enabled = true;
            botonconfiguracion.Enabled = true;
            botonproductos.Enabled = true;
            botoninventario.Enabled = true;
            botoncorte.Enabled = true;
            AbrirFormEnPanel(new Clientes());
        }

        private void botoninventario_Click(object sender, EventArgs e)
        {
            botoninventario.Enabled = false;
            if (Program.cargo != "Administrador" && Program.cargo != "Jefe")
            {
                botonventas.Enabled = true;
                botoncorte.Enabled = true;
            }
            else
            {
                botonconfiguracion.Enabled = true;
                botonclientes.Enabled = true;
                botonproductos.Enabled = true;
                botonventas.Enabled = true;
                botoncorte.Enabled = true;
            }
            AbrirFormEnPanel(new Inventario());
        }

        private void botoncorte_Click(object sender, EventArgs e)
        {
            botoncorte.Enabled = false;
            if (Program.cargo != "Administrador" && Program.cargo != "Jefe")
            {
                botonventas.Enabled = true;
                botoninventario.Enabled = true;
            }
            else
            {
                botonconfiguracion.Enabled = true;
                botonclientes.Enabled = true;
                botonproductos.Enabled = true;
                botonventas.Enabled = true;
                botoninventario.Enabled = true;
            }
            AbrirFormEnPanel(new Corte());
        }
    }
}
