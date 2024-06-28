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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Sistema_Gestion_de_MicroCreditos
{
    public partial class Presupuesto : Form
    {
        string usuario, contrasena,rol;
        public Presupuesto(string usuario, string contrasena,string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.rol = rol;
            string fecha = DateTime.Now.ToShortDateString();
            txtBoxFecha.Text = fecha;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(usuario, contrasena,rol);
            this.Close();
            ventanaPrincipal.Show();
        }

        private void btnIngresarMonto_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            string fechaActual = DateTime.Now.ToShortDateString();
            int parametro1 = Convert.ToInt32(txtBoxMonto.Text);


            cmd.CommandText = "UPDATE Presupuesto SET monto = monto + @monto, fecha = @fecha";
            cmd.Parameters.AddWithValue("@monto", parametro1);
            cmd.Parameters.AddWithValue("@fecha", fechaActual);

            SqlCommand cmd2 = new SqlCommand("");
            cmd2.Connection = conexion;

            MessageBox.Show("Presupuesto agregado");

            cmd.ExecuteNonQuery();
        }
    }
}
