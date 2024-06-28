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
    public partial class Cobros : Form
    {
        string usuario, contrasena,rol;
        public Cobros(string usuario,string contrasena,string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.rol = rol;
            MostrarRegistrosClientes();
            MostrarRegistrosPrestamos();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            VentanaPrincipal VentanaPrincipal = new VentanaPrincipal(usuario,contrasena,rol);
            this.Close();
            VentanaPrincipal.Show();
        }

        public void MostrarRegistrosClientes()
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True ");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM cliente";

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridView_Cliente.DataSource = dt;
            conexion.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM cliente WHERE idCliente = @idCliente";

            cmd.Parameters.AddWithValue("@idCliente", Convert.ToInt32(txtNumCedula.Text));


            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridView_Cliente.DataSource = dt;         



            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM prestamos WHERE idPrestamos = @idPrestamos";

            cmd.Parameters.AddWithValue("@idPrestamos", Convert.ToInt32(txtNumeroOp.Text));


            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridView_Prestamos.DataSource = dt;



            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarPrestamo();
            ActualizarCliente();
        }

        public void ActualizarPrestamo()
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM prestamos";
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridView_Prestamos.DataSource = dt;
        }

        public void ActualizarCliente()
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM cliente";
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridView_Cliente.DataSource = dt;

            txtNumCedula.Text = "";
        }
        double montoPrestamo, montoCuota, resultado;

        private void dataGridView_Prestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMontoPrestamo.Text = dataGridView_Prestamos.CurrentRow.Cells[6].Value.ToString();
            txtMontoCuota.Text = dataGridView_Prestamos.CurrentRow.Cells[13].Value.ToString();

        }

        private void dataGridView_Prestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMontoPrestamo.Text = dataGridView_Prestamos.CurrentRow.Cells[6].Value.ToString();
            txtMontoCuota.Text = dataGridView_Prestamos.CurrentRow.Cells[13].Value.ToString();
        }

        private void btn_reporte1_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cliente.Rows.Count > 0)

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

                            PdfPTable pTable = new PdfPTable(dataGridView_Cliente.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView_Cliente.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridView_Cliente.Rows)

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

        private void btnRporte_Click(object sender, EventArgs e)
        {
            if (dataGridView_Prestamos.Rows.Count > 0)

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

                            PdfPTable pTable = new PdfPTable(dataGridView_Prestamos.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView_Prestamos.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridView_Prestamos.Rows)

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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            montoPrestamo = Convert.ToDouble(txtMontoPrestamo.Text);
            montoCuota = Convert.ToDouble(txtMontoCuota.Text);

            resultado = montoPrestamo - montoCuota;
            txtPagar.Text = resultado.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string parametro;

            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

                parametro = txtPagar.Text;
                cmd.CommandText = "UPDATE prestamos SET montoPrestamo=@montoPrestamo WHERE idPrestamos=@idPrestamos";

                cmd.Parameters.AddWithValue("@idPrestamos", txtNumeroOp.Text);
                cmd.Parameters.AddWithValue("@montoPrestamo", parametro);

                cmd.ExecuteNonQuery();
            txtMontoPrestamo.Text = "";
            txtMontoCuota.Text = "";
            txtPagar.Text = "";
                MostrarRegistrosPrestamos();

        }

        public void MostrarRegistrosPrestamos()
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True ");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM prestamos";

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridView_Prestamos.DataSource = dt;
            conexion.Close();

            txtNumeroOp.Text = "";
        }
    }
}
