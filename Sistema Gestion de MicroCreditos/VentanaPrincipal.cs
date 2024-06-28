using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Sistema_Gestion_de_MicroCreditos
{
    public partial class VentanaPrincipal : Form
    {
        string usuario, contrasena,rol;

        public VentanaPrincipal(string usuario, string contrasena,string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.rol = rol;

            if (this.rol == "usuario")
            {
                btnCRUD_Usuarios.Visible = false;
                label1.Visible = false;
            }
            else if (this.rol == "soporte")
            {
                btnCRUD_Usuarios.Visible = false;
                label1.Visible = false;

                btnCobros.Visible = false;
                lblCobros.Visible = false;
            }
            else if (this.rol == "servicio al cliente")
            {
                btnCRUD_Usuarios.Visible=false;
                label1.Visible = false;

                btnPrestamos.Visible = false;
                lblPrestamo.Visible = false;

                btnCobros.Visible = false;
                lblCobros.Visible = false;

                pBPresupuesto.Visible = false;
                label5.Visible = false;
            }
            else if (this.rol == "supervisor")
            {
                btnCRUD_Usuarios.Visible = false;
                label1.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes(usuario,contrasena,rol);
            this.Hide();
            cliente.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo(usuario,contrasena,rol);
            this.Hide();
            prestamo.Show();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            Cobros cobros = new Cobros(usuario,contrasena,rol);
            this.Hide();
            cobros.Show();  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial(usuario, contrasena,rol);
            this.Hide();
            historial.Show();
        }

        private void btnCRUD_Usuarios_Click(object sender, EventArgs e)
        {
            Crud crud = new Crud(usuario,contrasena,rol);
            this.Hide();
            crud.Show();
        }

        private void pBPresupuesto_Click(object sender, EventArgs e)
        {
            Presupuesto presupuesto = new Presupuesto(usuario, contrasena,rol);
            this.Hide();
            presupuesto.Show();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
