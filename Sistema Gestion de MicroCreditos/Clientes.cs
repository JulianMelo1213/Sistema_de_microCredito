using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.text;

namespace Sistema_Gestion_de_MicroCreditos
{
    public partial class Clientes : Form
    {
        string usuario;
        string contrasena;
        string rol;

        public Clientes(string usuario,string contrasena,string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.rol = rol;
            RegistrosClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void RegistrosClientes()
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True ");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM cliente";

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable(); 

            dt.Load(dr);
            dataGridViewClientes.DataSource = dt;
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            if (txtBoxNombre.Text == "" || txtBoxApellidos.Text == "" || txtBoxCedula.Text == "" || txtBoxCiudad.Text == "" 
                || txtBoxCorreo.Text == "" || txtBoxDireccion.Text == "" || txtBoxTelefono.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos solicitados.");
            }
            else
            {
                cmd.CommandText = "INSERT INTO cliente (nombre,apellido,cedula,ciudad,direccion,correo_electronico,telefono) VALUES (@nombre,@apellido,@cedula,@ciudad,@direccion,@correo_electronico,@telefono)";

                cmd.Parameters.AddWithValue("@nombre", txtBoxNombre.Text);
                cmd.Parameters.AddWithValue("@apellido", txtBoxApellidos.Text);
                cmd.Parameters.AddWithValue("@cedula", txtBoxCedula.Text);
                cmd.Parameters.AddWithValue("@ciudad", txtBoxCiudad.Text);
                cmd.Parameters.AddWithValue("@direccion", txtBoxDireccion.Text);
                cmd.Parameters.AddWithValue("@correo_electronico", txtBoxCorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", txtBoxTelefono.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos se han sido registrados.");
                RegistrosClientes();

                Limpiar limpiar = new Limpiar();
                limpiar.Borrar(this);

            }
            conexion.Close();


        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(usuario,contrasena,rol);
            this.Close();
            ventanaPrincipal.Show();
    
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM cliente WHERE cedula = @cedula";

            cmd.Parameters.AddWithValue("@cedula", Convert.ToInt32(txtBoxCedula.Text));


            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridViewClientes.DataSource = dt;



            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        private void btnRporte_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (.pdf)|.pdf";

                save.FileName = "Resultado.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("No se pueden eliminar los datos en el disco" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dataGridViewClientes.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridViewClientes.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridViewClientes.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    pTable.AddCell(dcell.Value.ToString());

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Exportación correcta de datos", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error al exportar datos" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No se encontró ningún registro", "Info");

            }
        }
    }
}
