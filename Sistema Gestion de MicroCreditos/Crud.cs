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
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;


namespace Sistema_Gestion_de_MicroCreditos
{
    public partial class Crud : Form
    {
        string usuario, contrasena,rol;
        int posicion;
        public Crud(string usuario,string contrasena,string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.rol = rol;
            MostrarRegistros();
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void MostrarRegistros()
        {
            // Metodo para evitar tener que escribir el codigo para llenar y mostrar un dataGridView

            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True ");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM usuarios WHERE estado = 1";

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridViewUsuarios.DataSource = dt;
            conexion.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;


            if (txtUsuario.Text=="" || txtNombre.Text=="" || maskedTxtBoxContrasena.Text=="" || cbRol.Text=="")
            {
                MessageBox.Show("Ingrese todos los campos","Campos vacios",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                cmd.CommandText = "INSERT INTO usuarios (usuario,contrasena,nombre,idrol,estado) VALUES (@usuario,@contrasena,@nombre,@idrol,1)";

                cmd.Parameters.AddWithValue("@usuario",txtUsuario.Text);
                cmd.Parameters.AddWithValue("@contrasena",maskedTxtBoxContrasena.Text);
                cmd.Parameters.AddWithValue("@nombre",txtNombre.Text);
                cmd.Parameters.AddWithValue("@idrol",cbRol.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ha registrado el usuario","Usuario Registrado",MessageBoxButtons.OK);

                MostrarRegistros();

                Limpiar limpiar = new Limpiar();
                limpiar.Borrar(this);
                maskedTxtBoxContrasena.Text = "";
                cbRol.Text = "";
                
            }
            conexion.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM usuarios WHERE idusuario = @idusuario";

            cmd.Parameters.AddWithValue("@idusuario",Convert.ToInt32(txtBuscar.Text));

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridViewUsuarios.DataSource = dt;

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM usuarios";
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridViewUsuarios.DataSource = dt;

            txtBuscar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Boton Eliminar del CRUD

            int parametro;

            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            try
            {
                string ingreso = Interaction.InputBox("Ingrese el id del usuario", "Eliminar");
                parametro = Convert.ToInt32(ingreso);
                cmd.CommandText = "UPDATE usuarios SET estado=@estado WHERE idusuario=@idusuario";

                cmd.Parameters.AddWithValue("@idusuario", parametro);
                cmd.Parameters.AddWithValue("@estado",0);

                MessageBox.Show("Se ha borrado el usuario");
                cmd.ExecuteNonQuery();
                MostrarRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, Ingrese un valor numerico." + ex.Message);
            }
           
        }

        private void Crud_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nombre, usuario, contrasena, rol;

            nombre = txtNombre.Text;
            usuario = txtUsuario.Text;
            contrasena = maskedTxtBoxContrasena.Text;
            rol = cbRol.Text;

            dataGridViewUsuarios[1, posicion].Value = txtNombre.Text;
            dataGridViewUsuarios[2, posicion].Value = txtUsuario.Text;
            dataGridViewUsuarios[3, posicion].Value = maskedTxtBoxContrasena.Text;
            dataGridViewUsuarios[4, posicion].Value = cbRol.Text;

          
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "UPDATE usuarios SET usuario=@usuario, contrasena=@contrasena,nombre=@nombre,idrol=@idrol  WHERE idusuario=@idusuario";

            cmd.Parameters.AddWithValue("@idusuario", txtBuscar.Text);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@contrasena", maskedTxtBoxContrasena.Text);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@idrol", cbRol.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();


            dt.Load(dr);
            dataGridViewUsuarios.DataSource = dt;

            txtNombre.Text = "";
            txtUsuario.Text = "";
            maskedTxtBoxContrasena.Text = "";
            cbRol.Text = "";

            txtNombre.Focus();

            MostrarRegistros();
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridViewUsuarios.CurrentRow.Index;
            txtNombre.Text = dataGridViewUsuarios[3, posicion].Value.ToString();
            txtUsuario.Text = dataGridViewUsuarios[1, posicion].Value.ToString();
            maskedTxtBoxContrasena.Text = dataGridViewUsuarios[2, posicion].Value.ToString();
            cbRol.Text = dataGridViewUsuarios[4, posicion].Value.ToString();
            txtBuscar.Text = dataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString();

            txtNombre.Text = dataGridViewUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtUsuario.Text = dataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
            maskedTxtBoxContrasena.Text = dataGridViewUsuarios.CurrentRow.Cells[2].Value.ToString();
            cbRol.Text = dataGridViewUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtBuscar.Text = dataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString();

            txtNombre.Focus();
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dataGridViewUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtUsuario.Text = dataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
            maskedTxtBoxContrasena.Text = dataGridViewUsuarios.CurrentRow.Cells[2].Value.ToString();
            cbRol.Text = dataGridViewUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtBuscar.Text = dataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString();


            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtUsuario.Text = "";
            maskedTxtBoxContrasena.Text = "";
            txtBuscar.Text = "";
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            VentanaPrincipal VentanaPrincipal = new VentanaPrincipal(usuario,contrasena,rol);
            this.Close();
            VentanaPrincipal.Show();
        }
    }
}
