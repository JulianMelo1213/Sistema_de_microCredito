namespace Sistema_Gestion_de_MicroCreditos
{
    partial class Presupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presupuesto));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnIngresarMonto = new System.Windows.Forms.Button();
            this.txtBoxMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Cyan;
            this.BarraTitulo.Controls.Add(this.label14);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Location = new System.Drawing.Point(-45, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(579, 38);
            this.BarraTitulo.TabIndex = 8;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(56, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(306, 30);
            this.label14.TabIndex = 12;
            this.label14.Text = "Registro de Presupuesto";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(514, 4);
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
            this.btnCerrar.Location = new System.Drawing.Point(549, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIngresarMonto
            // 
            this.btnIngresarMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarMonto.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarMonto.Image")));
            this.btnIngresarMonto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresarMonto.Location = new System.Drawing.Point(328, 236);
            this.btnIngresarMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarMonto.Name = "btnIngresarMonto";
            this.btnIngresarMonto.Size = new System.Drawing.Size(116, 75);
            this.btnIngresarMonto.TabIndex = 9;
            this.btnIngresarMonto.Text = "Ingresar";
            this.btnIngresarMonto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresarMonto.UseVisualStyleBackColor = true;
            this.btnIngresarMonto.Click += new System.EventHandler(this.btnIngresarMonto_Click);
            // 
            // txtBoxMonto
            // 
            this.txtBoxMonto.Location = new System.Drawing.Point(214, 86);
            this.txtBoxMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxMonto.Name = "txtBoxMonto";
            this.txtBoxMonto.Size = new System.Drawing.Size(116, 22);
            this.txtBoxMonto.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Monto";
            // 
            // txtBoxFecha
            // 
            this.txtBoxFecha.Location = new System.Drawing.Point(214, 179);
            this.txtBoxFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxFecha.Name = "txtBoxFecha";
            this.txtBoxFecha.ReadOnly = true;
            this.txtBoxFecha.Size = new System.Drawing.Size(116, 22);
            this.txtBoxFecha.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha";
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.Image = ((System.Drawing.Image)(resources.GetObject("btnRetroceder.Image")));
            this.btnRetroceder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRetroceder.Location = new System.Drawing.Point(99, 232);
            this.btnRetroceder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(111, 78);
            this.btnRetroceder.TabIndex = 12;
            this.btnRetroceder.Text = "Volver";
            this.btnRetroceder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // Presupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(533, 338);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFecha);
            this.Controls.Add(this.txtBoxMonto);
            this.Controls.Add(this.btnIngresarMonto);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Presupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuesto";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnIngresarMonto;
        private System.Windows.Forms.TextBox txtBoxMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRetroceder;
    }
}