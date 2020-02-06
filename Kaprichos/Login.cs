using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaConexión;
using Tulpep.NotificationWindow;

namespace Kaprichos
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Login()
        {
            InitializeComponent();
        }

        private void botonminimizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            usuario.Focus();
        }

        private void contra_Enter(object sender, EventArgs e)
        {
            contra.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MostrarUsuarios()
        {
            CCConsultas cCConsultas = new CCConsultas();
            usuario.DataSource = cCConsultas.MostrarUsuarios();
            usuario.ValueMember = "usuario";
            usuario.DisplayMember = "usuario";
        }

        private void entrar()
        {
            CCConsultas cCConsultas = new CCConsultas();
            SqlDataReader Loguear;
            Loguear = cCConsultas.IniciarSesion(usuario.Text, contra.Text);
            if (Loguear.Read() == true)
            {
                PopupNotifier pn = new PopupNotifier();
                pn.TitleText = "¡Bienvenido " + usuario.Text + "!";
                //pn.Image = Properties.Resources.kapchico;
                pn.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(106)))));
                pn.TitleFont = new System.Drawing.Font("Century Gothic", 25F);
                pn.Size = new System.Drawing.Size(400, 100); 
                pn.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(106)))));
                pn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(175)))), ((int)(((byte)(106)))));
                pn.Popup();
                this.Close();
                Principal pri = new Principal();
                Program.cargo = Loguear["cargo"].ToString();
                Program.usuario = Loguear["usuario"].ToString();
                pri.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contra.Focus();
                contra.SelectAll();
            }
        }

        private void botonentrar_Click(object sender, EventArgs e)
        {
            entrar();
        }

        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                
        }

        private void contra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                entrar();
            }
        }

        private void usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
