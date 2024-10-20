namespace Laboratorio14
{
    partial class frmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            tstId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtStock = new TextBox();
            label5 = new Label();
            tsbBuscar = new PictureBox();
            tsbGuardar = new PictureBox();
            tsbNuevo = new PictureBox();
            tsbCancelar = new PictureBox();
            tsbEliminar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(27, 210);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 35);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tstId
            // 
            tstId.Location = new Point(225, 7);
            tstId.Name = "tstId";
            tstId.Size = new Size(100, 23);
            tstId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 52);
            label1.Name = "label1";
            label1.Size = new Size(20, 17);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 135);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 3;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 52);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(163, 135);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 5;
            label4.Text = "Stock";
            // 
            // txtId
            // 
            txtId.Location = new Point(27, 81);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 23);
            txtId.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(27, 166);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(114, 23);
            txtPrecio.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(447, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(163, 166);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(130, 10);
            label5.Name = "label5";
            label5.Size = new Size(91, 17);
            label5.TabIndex = 10;
            label5.Text = "Buscar por id:";
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = Properties.Resources.buscar;
            tsbBuscar.Location = new Point(330, 7);
            tsbBuscar.Margin = new Padding(2, 3, 3, 3);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(23, 23);
            tsbBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbBuscar.TabIndex = 11;
            tsbBuscar.TabStop = false;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.Image = Properties.Resources.guardar;
            tsbGuardar.Location = new Point(41, 7);
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(23, 23);
            tsbGuardar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbGuardar.TabIndex = 12;
            tsbGuardar.TabStop = false;
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.nuevo;
            tsbNuevo.Location = new Point(12, 7);
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(23, 23);
            tsbNuevo.SizeMode = PictureBoxSizeMode.Zoom;
            tsbNuevo.TabIndex = 13;
            tsbNuevo.TabStop = false;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.Image = Properties.Resources.cancelar;
            tsbCancelar.Location = new Point(69, 7);
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(23, 23);
            tsbCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbCancelar.TabIndex = 14;
            tsbCancelar.TabStop = false;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = Properties.Resources.eliminar;
            tsbEliminar.Location = new Point(98, 7);
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(23, 23);
            tsbEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            tsbEliminar.TabIndex = 15;
            tsbEliminar.TabStop = false;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 270);
            Controls.Add(tsbEliminar);
            Controls.Add(tsbCancelar);
            Controls.Add(tsbNuevo);
            Controls.Add(tsbGuardar);
            Controls.Add(tsbBuscar);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(txtNombre);
            Controls.Add(txtPrecio);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tstId);
            Controls.Add(btnSalir);
            Name = "frmProductos";
            Text = "Productos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private TextBox tstId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtStock;
        private Label label5;
        private PictureBox tsbBuscar;
        private PictureBox tsbGuardar;
        private PictureBox tsbNuevo;
        private PictureBox tsbCancelar;
        private PictureBox tsbEliminar;
    }
}
