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
using Microsoft.VisualBasic;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.text;

namespace Sistema_Gestion_de_MicroCreditos
{
    public partial class Historial : Form
    {
        string usuario, contrasena,rol;
        public Historial(string usuario, string contrasena,string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.rol = rol; 
            MostrarRegistros();
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

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(usuario,contrasena,rol);
            ventanaPrincipal.Show();
        }

        public void MostrarRegistros()
        {
            // Metodo para evitar tener que escribir el codigo para llenar y mostrar un dataGridView

            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True ");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM prestamos";

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridView_HistorialPres.DataSource = dt;
            conexion.Close();
        }

        private void btnRetroceder_Click_1(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(usuario, contrasena,rol);
            ventanaPrincipal.Show();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM prestamos WHERE idPrestamos = @idPrestamos";

            cmd.Parameters.AddWithValue("@idPrestamos", Convert.ToInt32(txtIdCliente.Text));


            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridView_HistorialPres.DataSource = dt;

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        private void btnRporte_Click(object sender, EventArgs e)
        {
            if (dataGridView_HistorialPres.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (.pdf)|.pdf";

                save.FileName = "Result.pdf";

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

                            PdfPTable pTable = new PdfPTable(dataGridView_HistorialPres.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView_HistorialPres.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridView_HistorialPres.Rows)

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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            try
            {
                string estado = "I";
                cmd.CommandText = "UPDATE prestamos SET estado=@estado WHERE idPrestamos=@idPrestamos";

                cmd.Parameters.AddWithValue("@idPrestamos", txtIdCliente.Text);
                cmd.Parameters.AddWithValue("@estado", estado);

                MessageBox.Show("Se ha cancelado el prestamo");
                cmd.ExecuteNonQuery();
                MostrarRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, Ingrese un valor numerico." + ex.Message);
            }
        }

    }
}
