namespace Sistema_Gestion_de_MicroCreditos
{
    partial class Cobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobros));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroOp = new System.Windows.Forms.TextBox();
            this.txtNumCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView_Cliente = new System.Windows.Forms.DataGridView();
            this.dataGridView_Prestamos = new System.Windows.Forms.DataGridView();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRporte = new System.Windows.Forms.Button();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.txtMontoCuota = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_reporte1 = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Cyan;
            this.BarraTitulo.Controls.Add(this.label2);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1120, 30);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cobros";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1090, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1057, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnPagar.Image")));
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagar.Location = new System.Drawing.Point(1009, 356);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(98, 95);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.Image = ((System.Drawing.Image)(resources.GetObject("btnRetroceder.Image")));
            this.btnRetroceder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRetroceder.Location = new System.Drawing.Point(1009, 457);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(98, 95);
            this.btnRetroceder.TabIndex = 2;
            this.btnRetroceder.Text = "Volver";
            this.btnRetroceder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id de prestamo:";
            // 
            // txtNumeroOp
            // 
            this.txtNumeroOp.Location = new System.Drawing.Point(160, 301);
            this.txtNumeroOp.Name = "txtNumeroOp";
            this.txtNumeroOp.Size = new System.Drawing.Size(107, 22);
            this.txtNumeroOp.TabIndex = 4;
            // 
            // txtNumCedula
            // 
            this.txtNumCedula.Location = new System.Drawing.Point(160, 38);
            this.txtNumCedula.Name = "txtNumCedula";
            this.txtNumCedula.Size = new System.Drawing.Size(107, 22);
            this.txtNumCedula.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id del cliente:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(273, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 44);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView_Cliente
            // 
            this.dataGridView_Cliente.AllowUserToAddRows = false;
            this.dataGridView_Cliente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cliente.Location = new System.Drawing.Point(0, 77);
            this.dataGridView_Cliente.Name = "dataGridView_Cliente";
            this.dataGridView_Cliente.RowHeadersWidth = 51;
            this.dataGridView_Cliente.RowTemplate.Height = 24;
            this.dataGridView_Cliente.Size = new System.Drawing.Size(1003, 193);
            this.dataGridView_Cliente.TabIndex = 8;
            this.dataGridView_Cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Cliente_CellContentClick);
            // 
            // dataGridView_Prestamos
            // 
            this.dataGridView_Prestamos.AllowUserToAddRows = false;
            this.dataGridView_Prestamos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Prestamos.Location = new System.Drawing.Point(0, 339);
            this.dataGridView_Prestamos.Name = "dataGridView_Prestamos";
            this.dataGridView_Prestamos.RowHeadersWidth = 51;
            this.dataGridView_Prestamos.RowTemplate.Height = 24;
            this.dataGridView_Prestamos.Size = new System.Drawing.Size(1003, 167);
            this.dataGridView_Prestamos.TabIndex = 9;
            this.dataGridView_Prestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Prestamos_CellClick);
            this.dataGridView_Prestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Prestamos_CellContentClick);
            // 
            // txtPagar
            // 
            this.txtPagar.Location = new System.Drawing.Point(257, 572);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Size = new System.Drawing.Size(107, 22);
            this.txtPagar.TabIndex = 13;
            this.txtPagar.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Importe a pagar:";
            this.label4.Visible = false;
            // 
            // btnRporte
            // 
            this.btnRporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRporte.Image = ((System.Drawing.Image)(resources.GetObject("btnRporte.Image")));
            this.btnRporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRporte.Location = new System.Drawing.Point(986, 558);
            this.btnRporte.Name = "btnRporte";
            this.btnRporte.Size = new System.Drawing.Size(131, 41);
            this.btnRporte.TabIndex = 14;
            this.btnRporte.Text = "Reporte";
            this.btnRporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRporte.UseVisualStyleBackColor = true;
            this.btnRporte.Click += new System.EventHandler(this.btnRporte_Click);
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar2.Image")));
            this.btnBuscar2.Location = new System.Drawing.Point(273, 290);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(75, 44);
            this.btnBuscar2.TabIndex = 15;
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(1032, 33);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 44);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(257, 512);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(107, 22);
            this.txtMontoPrestamo.TabIndex = 17;
            // 
            // txtMontoCuota
            // 
            this.txtMontoCuota.Location = new System.Drawing.Point(257, 540);
            this.txtMontoCuota.Name = "txtMontoCuota";
            this.txtMontoCuota.Size = new System.Drawing.Size(107, 22);
            this.txtMontoCuota.TabIndex = 18;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(885, 512);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 40);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Monto del prestamo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Monto de cuota:";
            // 
            // btn_reporte1
            // 
            this.btn_reporte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte1.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporte1.Image")));
            this.btn_reporte1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reporte1.Location = new System.Drawing.Point(1005, 94);
            this.btn_reporte1.Name = "btn_reporte1";
            this.btn_reporte1.Size = new System.Drawing.Size(115, 41);
            this.btn_reporte1.TabIndex = 22;
            this.btn_reporte1.Text = "Reporte";
            this.btn_reporte1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reporte1.UseVisualStyleBackColor = true;
            this.btn_reporte1.Click += new System.EventHandler(this.btn_reporte1_Click);
            // 
            // Cobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1119, 611);
            this.Controls.Add(this.btn_reporte1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMontoCuota);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.btnRporte);
            this.Controls.Add(this.txtPagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_Prestamos);
            this.Controls.Add(this.dataGridView_Cliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroOp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroOp;
        private System.Windows.Forms.TextBox txtNumCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView_Cliente;
        private System.Windows.Forms.DataGridView dataGridView_Prestamos;
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRporte;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.TextBox txtMontoCuota;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reporte1;
    }
}