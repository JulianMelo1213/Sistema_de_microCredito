namespace Sistema_Gestion_de_MicroCreditos
{
    partial class Prestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamo));
            this.txtFechaRegistro = new System.Windows.Forms.TextBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_microprestamosDataSet = new Sistema_Gestion_de_MicroCreditos.BD_microprestamosDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNOperacion = new System.Windows.Forms.TextBox();
            this.txtMontoPrest = new System.Windows.Forms.TextBox();
            this.txtNumerodeAños = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbInteres = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMontoCuotas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.cbClausula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnRporte = new System.Windows.Forms.Button();
            this.dataGridViewCuotas = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new Sistema_Gestion_de_MicroCreditos.BD_microprestamosDataSetTableAdapters.clienteTableAdapter();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_microprestamosDataSet)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Location = new System.Drawing.Point(199, 89);
            this.txtFechaRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Size = new System.Drawing.Size(121, 22);
            this.txtFechaRegistro.TabIndex = 1;
            // 
            // cbCliente
            // 
            this.cbCliente.DataSource = this.clienteBindingSource;
            this.cbCliente.DisplayMember = "idCliente";
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(12, 89);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(108, 24);
            this.cbCliente.TabIndex = 2;
            this.cbCliente.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.bD_microprestamosDataSet;
            // 
            // bD_microprestamosDataSet
            // 
            this.bD_microprestamosDataSet.DataSetName = "BD_microprestamosDataSet";
            this.bD_microprestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "N. de Operacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Monto del Prestamo";
            // 
            // txtNOperacion
            // 
            this.txtNOperacion.Location = new System.Drawing.Point(12, 174);
            this.txtNOperacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNOperacion.Name = "txtNOperacion";
            this.txtNOperacion.Size = new System.Drawing.Size(106, 22);
            this.txtNOperacion.TabIndex = 1;
            // 
            // txtMontoPrest
            // 
            this.txtMontoPrest.Location = new System.Drawing.Point(199, 174);
            this.txtMontoPrest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoPrest.Name = "txtMontoPrest";
            this.txtMontoPrest.Size = new System.Drawing.Size(131, 22);
            this.txtMontoPrest.TabIndex = 1;
            // 
            // txtNumerodeAños
            // 
            this.txtNumerodeAños.Location = new System.Drawing.Point(415, 91);
            this.txtNumerodeAños.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumerodeAños.Name = "txtNumerodeAños";
            this.txtNumerodeAños.Size = new System.Drawing.Size(131, 22);
            this.txtNumerodeAños.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Forma de Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(410, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Fecha de Inicio";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 172);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(415, 255);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(118, 22);
            this.txtMontoTotal.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Monto por Cuotas";
            // 
            // cbInteres
            // 
            this.cbInteres.FormattingEnabled = true;
            this.cbInteres.Items.AddRange(new object[] {
            "1.15",
            "2.00"});
            this.cbInteres.Location = new System.Drawing.Point(199, 271);
            this.cbInteres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbInteres.Name = "cbInteres";
            this.cbInteres.Size = new System.Drawing.Size(108, 24);
            this.cbInteres.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(194, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Interes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(410, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Monto Total";
            // 
            // txtMontoCuotas
            // 
            this.txtMontoCuotas.Location = new System.Drawing.Point(12, 345);
            this.txtMontoCuotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoCuotas.Name = "txtMontoCuotas";
            this.txtMontoCuotas.Size = new System.Drawing.Size(118, 22);
            this.txtMontoCuotas.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(194, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Clausula";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Cyan;
            this.BarraTitulo.Controls.Add(this.label14);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Location = new System.Drawing.Point(0, 1);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(802, 34);
            this.BarraTitulo.TabIndex = 7;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(283, 30);
            this.label14.TabIndex = 12;
            this.label14.Text = "Registro de Prestamos";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(734, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(767, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbClausula
            // 
            this.cbClausula.FormattingEnabled = true;
            this.cbClausula.Items.AddRange(new object[] {
            "Clausula 01",
            "Clausula 02",
            "Clausula 03"});
            this.cbClausula.Location = new System.Drawing.Point(199, 343);
            this.cbClausula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClausula.Name = "cbClausula";
            this.cbClausula.Size = new System.Drawing.Size(108, 24);
            this.cbClausula.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numero de años";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cbFormaPago.Location = new System.Drawing.Point(12, 273);
            this.cbFormaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(108, 24);
            this.cbFormaPago.TabIndex = 12;
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.Image = ((System.Drawing.Image)(resources.GetObject("btnRetroceder.Image")));
            this.btnRetroceder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRetroceder.Location = new System.Drawing.Point(683, 158);
            this.btnRetroceder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(111, 78);
            this.btnRetroceder.TabIndex = 13;
            this.btnRetroceder.Text = "Volver";
            this.btnRetroceder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrar.Location = new System.Drawing.Point(683, 64);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(111, 78);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnRporte
            // 
            this.btnRporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRporte.Image = ((System.Drawing.Image)(resources.GetObject("btnRporte.Image")));
            this.btnRporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRporte.Location = new System.Drawing.Point(683, 250);
            this.btnRporte.Name = "btnRporte";
            this.btnRporte.Size = new System.Drawing.Size(111, 78);
            this.btnRporte.TabIndex = 16;
            this.btnRporte.Text = "Reporte";
            this.btnRporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRporte.UseVisualStyleBackColor = true;
            this.btnRporte.Click += new System.EventHandler(this.btnRporte_Click);
            // 
            // dataGridViewCuotas
            // 
            this.dataGridViewCuotas.AllowUserToAddRows = false;
            this.dataGridViewCuotas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuotas.Location = new System.Drawing.Point(0, 444);
            this.dataGridViewCuotas.Name = "dataGridViewCuotas";
            this.dataGridViewCuotas.RowHeadersWidth = 51;
            this.dataGridViewCuotas.RowTemplate.Height = 24;
            this.dataGridViewCuotas.Size = new System.Drawing.Size(685, 194);
            this.dataGridViewCuotas.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(412, 338);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(254, 22);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha de fin";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcular.Location = new System.Drawing.Point(683, 342);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 78);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(822, 658);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewCuotas);
            this.Controls.Add(this.btnRporte);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.cbFormaPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClausula);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbInteres);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.txtNumerodeAños);
            this.Controls.Add(this.txtMontoCuotas);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.txtMontoPrest);
            this.Controls.Add(this.txtNOperacion);
            this.Controls.Add(this.txtFechaRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Prestamo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_microprestamosDataSet)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFechaRegistro;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNOperacion;
        private System.Windows.Forms.TextBox txtMontoPrest;
        private System.Windows.Forms.TextBox txtNumerodeAños;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbInteres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMontoCuotas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ComboBox cbClausula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnRporte;
        private System.Windows.Forms.DataGridView dataGridViewCuotas;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private BD_microprestamosDataSet bD_microprestamosDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BD_microprestamosDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button btnCalcular;
    }
}

