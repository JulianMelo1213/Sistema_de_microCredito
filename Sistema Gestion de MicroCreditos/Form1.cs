using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Mail;


namespace Sistema_Gestion_de_MicroCreditos
{
    public partial class Form1 : Form
    {
        int segundos;
        int intentos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source = LAPTOP-TGPNUPFI;Initial Catalog = BD_microprestamos;Integrated Security = True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT usuario,contrasena,idrol FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena";
            cmd.Parameters.AddWithValue("@usuario", txtBoxUsuario.Text);
            cmd.Parameters.AddWithValue("@contrasena", maskedTxtBoxContraseña.Text);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bienvenido al Sistema de Micro Prestamos");
                string usuario = txtBoxUsuario.Text;
                string contrasena = maskedTxtBoxContraseña.Text;
                string rol = dt.Rows[0][2].ToString();
                this.Hide();

                if (dt.Rows[0][2].ToString() == "admin")
                {
                    VentanaPrincipal VentanaPrincipal = new VentanaPrincipal(usuario, contrasena, rol);
                    VentanaPrincipal.Show();
                    MessageBox.Show("Hola admin");
                }

                else if (dt.Rows[0][2].ToString() == "usuario")
                {
                    VentanaPrincipal VentanaPrincipal = new VentanaPrincipal(usuario, contrasena, rol);
                    VentanaPrincipal.Show();
                    MessageBox.Show("Hola usuario");
                }

                else if (dt.Rows[0][2].ToString() == "soporte")
                {
                    VentanaPrincipal VentanaPrincipal = new VentanaPrincipal(usuario, contrasena, rol);
                    VentanaPrincipal.Show();
                    MessageBox.Show("Hola soporte tecnico");
                }

                else if (dt.Rows[0][2].ToString() == "supervisor")
                {
                    VentanaPrincipal VentanaPrincipal = new VentanaPrincipal(usuario, contrasena, rol);
                    VentanaPrincipal.Show();
                    MessageBox.Show("Hola supervisor");
                }

                else if (dt.Rows[0][2].ToString() == "servicio al cliente")
                {
                    VentanaPrincipal VentanaPrincipal = new VentanaPrincipal(usuario, contrasena, rol);
                    VentanaPrincipal.Show();
                    MessageBox.Show("Hola Servicio al Cliente");

                }


            }
            else
            {
                MessageBox.Show("Usuario o Contrasena incorrectos.");
                intentos += 1;
            }
            if (intentos == 3)
            {
                lblContador.Visible = true;
                txtBoxUsuario.Enabled = false;
                maskedTxtBoxContraseña.Enabled = false;
                btnIngresar.Enabled = false;

                segundos = 10;

                timerBloqueo.Start();

                MessageBox.Show("Ha excedido el numero de intentos. Se ha enviado una notificacion al administrador.", "Bloqueo Temporal", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                EnvioCorreo EnvioCorreo = new EnvioCorreo();

                string body = @"<style>
                            h3{color:LighSalmon;}
                            </style>
                            <h3>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                            Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo 
                            consequat.</h3>";

                EnvioCorreo.EnviarEmail("orlandofranjul7@gmail.com", "Sistema de Gestion de MicroPrestamos", body);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerBloqueo_Tick(object sender, EventArgs e)
        {
            
            lblContador.Text = "Vuelvalo a intentar en: " + segundos--.ToString();
            if (segundos < 0)
            {
                timerBloqueo.Stop();
                intentos = 0;
                lblContador.Text = "";
                lblContador.Visible = false;
                txtBoxUsuario.Enabled = true;
                maskedTxtBoxContraseña.Enabled = true;
                btnIngresar.Enabled = true; 
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
