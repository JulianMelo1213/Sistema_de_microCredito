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
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.text;


namespace Sistema_Gestion_de_MicroCreditos
{
    public partial class Prestamo : Form
    {
        string usuario, contrasena,rol;
        double interes, interesMensual, prestamoPedido, pagoMensual, totalPagado, numeroDeAños;
        public Prestamo(string usuario,string contrasena,string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.rol = rol;
            MostrarRegistros();
            cbClausula.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInteres.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Prestamo_Load(object sender, EventArgs e)
        {

        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPrincipal ventanaprincipal = new VentanaPrincipal(usuario,contrasena,rol);
            ventanaprincipal.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            

            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;
            string estado = "A";
            string fechaInicio = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string fechaFin = dateTimePicker2.Value.ToString("dd/MM/yyyy");

            if (txtNOperacion.Text == "" || txtMontoTotal.Text == "" || txtMontoPrest.Text == "" || txtMontoCuotas.Text == "" || txtFechaRegistro.Text == "" || txtNumerodeAños.Text == ""
                || cbClausula.Text == "" || cbCliente.Text == "" || cbFormaPago.Text == "" || cbInteres.Text == "" ) 
            {
                MessageBox.Show("Ingrese todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd.CommandText = "insert into prestamos(numeroOperacion, fechaRegistro, idTipoPago,fechaInicio,fechaFin, montoPrestamo,interes, numeroDeCuotas, montoTotal, idCliente, estado, clausula, montoCuotas ) values(@numeroOperacion, @fechaRegistro, 1 ,@fechaInicio,@fechaFin, @montoPrestamo,@interes, @numeroDeCuotas, @montoTotal, @idCliente, @estado, @clausula, @montoCuotas); ";

                cmd.Parameters.AddWithValue("@numeroOperacion", txtNOperacion.Text);
                cmd.Parameters.AddWithValue("@numeroDeCuotas", txtNumerodeAños.Text);
                cmd.Parameters.AddWithValue("@fechaRegistro", txtFechaRegistro.Text);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                cmd.Parameters.AddWithValue("@montoPrestamo", txtMontoPrest.Text);
                cmd.Parameters.AddWithValue("@interes", cbInteres.Text);
                cmd.Parameters.AddWithValue("@montoTotal", txtMontoTotal.Text);
                cmd.Parameters.AddWithValue("@idCliente", cbCliente.Text);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@clausula", cbClausula.Text);
                cmd.Parameters.AddWithValue("@montoCuotas", txtMontoCuotas.Text);





                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ha registrado el prestamo", "Prestamo Registrado", MessageBoxButtons.OK);

                MostrarRegistros();

                Limpiar limpiar = new Limpiar();
                limpiar.Borrar(this);

            }
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

        private void btnRporte_Click(object sender, EventArgs e)
        {
            if (dataGridViewCuotas.Rows.Count > 0)

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

                            PdfPTable pTable = new PdfPTable(dataGridViewCuotas.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridViewCuotas.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridViewCuotas.Rows)

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

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Prestamo_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_microprestamosDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bD_microprestamosDataSet.cliente);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillBy(this.bD_microprestamosDataSet.cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //double interes, interesMensual, prestamoPedido, pagoMensual, totalPagado, numeroDeAños;
        string iMontlyPayment;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            interes = Convert.ToDouble(cbInteres.Text);
            interesMensual = interes / 1200;
            numeroDeAños = Convert.ToDouble(txtNumerodeAños.Text);
            prestamoPedido = Convert.ToDouble(txtMontoPrest.Text);

            pagoMensual = prestamoPedido * interesMensual / (1 - 1 / Math.Pow(1 + interesMensual, numeroDeAños * 12));
            iMontlyPayment = Convert.ToString(pagoMensual);
            txtMontoCuotas.Text = (iMontlyPayment); 

            totalPagado = pagoMensual * numeroDeAños * 12;
            txtMontoTotal.Text = totalPagado.ToString();

            txtMontoPrest.Text = prestamoPedido.ToString();

        }

        public void MostrarRegistros()
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-TGPNUPFI;Initial Catalog=BD_microprestamos;Integrated Security=True ");
            conexion.Open();

            SqlCommand cmd = new SqlCommand("");
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT * FROM prestamos";

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dataGridViewCuotas.DataSource = dt;
            conexion.Close();
        }


    }
}
