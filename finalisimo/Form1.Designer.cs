namespace finalisimo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcTipo = new System.Windows.Forms.GroupBox();
            this.optMountain = new System.Windows.Forms.RadioButton();
            this.optTodos = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcRegistroDeAlquileres = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.comboBoxTipoBicicleta = new System.Windows.Forms.ComboBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkPago = new System.Windows.Forms.CheckBox();
            this.chkCasco = new System.Windows.Forms.CheckBox();
            this.chkProtecciones = new System.Windows.Forms.CheckBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblTipodeBicicleta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.mrcTipo.SuspendLayout();
            this.mrcRegistroDeAlquileres.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToOrderColumns = true;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv1.Location = new System.Drawing.Point(12, 334);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(448, 165);
            this.dgv1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bicicleta";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dias";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Importe";
            this.Column4.Name = "Column4";
            // 
            // mrcTipo
            // 
            this.mrcTipo.Controls.Add(this.optMountain);
            this.mrcTipo.Controls.Add(this.optTodos);
            this.mrcTipo.Controls.Add(this.btnConsultar);
            this.mrcTipo.Location = new System.Drawing.Point(12, 270);
            this.mrcTipo.Name = "mrcTipo";
            this.mrcTipo.Size = new System.Drawing.Size(448, 58);
            this.mrcTipo.TabIndex = 7;
            this.mrcTipo.TabStop = false;
            this.mrcTipo.Text = "Tipo de Consulta";
            // 
            // optMountain
            // 
            this.optMountain.AutoSize = true;
            this.optMountain.Location = new System.Drawing.Point(171, 25);
            this.optMountain.Name = "optMountain";
            this.optMountain.Size = new System.Drawing.Size(175, 17);
            this.optMountain.TabIndex = 11;
            this.optMountain.TabStop = true;
            this.optMountain.Text = "Alquileres de tipo Mountain bike";
            this.optMountain.UseVisualStyleBackColor = true;
            // 
            // optTodos
            // 
            this.optTodos.AutoSize = true;
            this.optTodos.Location = new System.Drawing.Point(32, 25);
            this.optTodos.Name = "optTodos";
            this.optTodos.Size = new System.Drawing.Size(119, 17);
            this.optTodos.TabIndex = 10;
            this.optTodos.TabStop = true;
            this.optTodos.Text = "Todos los Alquileres";
            this.optTodos.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(352, 15);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 37);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // mrcRegistroDeAlquileres
            // 
            this.mrcRegistroDeAlquileres.Controls.Add(this.txtDias);
            this.mrcRegistroDeAlquileres.Controls.Add(this.comboBoxTipoBicicleta);
            this.mrcRegistroDeAlquileres.Controls.Add(this.txtImporte);
            this.mrcRegistroDeAlquileres.Controls.Add(this.txtNombre);
            this.mrcRegistroDeAlquileres.Controls.Add(this.lblImporte);
            this.mrcRegistroDeAlquileres.Controls.Add(this.mrcAdicionales);
            this.mrcRegistroDeAlquileres.Controls.Add(this.lblDias);
            this.mrcRegistroDeAlquileres.Controls.Add(this.lblTipodeBicicleta);
            this.mrcRegistroDeAlquileres.Controls.Add(this.lblNombre);
            this.mrcRegistroDeAlquileres.Controls.Add(this.btnRegistrar);
            this.mrcRegistroDeAlquileres.Controls.Add(this.btnSalir);
            this.mrcRegistroDeAlquileres.Controls.Add(this.btnCalcular);
            this.mrcRegistroDeAlquileres.Location = new System.Drawing.Point(12, 12);
            this.mrcRegistroDeAlquileres.Name = "mrcRegistroDeAlquileres";
            this.mrcRegistroDeAlquileres.Size = new System.Drawing.Size(448, 252);
            this.mrcRegistroDeAlquileres.TabIndex = 6;
            this.mrcRegistroDeAlquileres.TabStop = false;
            this.mrcRegistroDeAlquileres.Text = "Registro De Alquileres";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(146, 99);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(49, 20);
            this.txtDias.TabIndex = 10;
            // 
            // comboBoxTipoBicicleta
            // 
            this.comboBoxTipoBicicleta.FormattingEnabled = true;
            this.comboBoxTipoBicicleta.Items.AddRange(new object[] {
            "Adulto de Paseo",
            "Adulto Mountain Bike",
            "Niño de Paseo"});
            this.comboBoxTipoBicicleta.Location = new System.Drawing.Point(146, 70);
            this.comboBoxTipoBicicleta.Name = "comboBoxTipoBicicleta";
            this.comboBoxTipoBicicleta.Size = new System.Drawing.Size(189, 21);
            this.comboBoxTipoBicicleta.TabIndex = 9;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(119, 215);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(67, 20);
            this.txtImporte.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(27, 222);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(69, 13);
            this.lblImporte.TabIndex = 6;
            this.lblImporte.Text = "Importe Total";
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkPago);
            this.mrcAdicionales.Controls.Add(this.chkCasco);
            this.mrcAdicionales.Controls.Add(this.chkProtecciones);
            this.mrcAdicionales.Location = new System.Drawing.Point(19, 138);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(327, 71);
            this.mrcAdicionales.TabIndex = 4;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Opciones Adicionales";
            // 
            // chkPago
            // 
            this.chkPago.AutoSize = true;
            this.chkPago.Location = new System.Drawing.Point(179, 19);
            this.chkPago.Name = "chkPago";
            this.chkPago.Size = new System.Drawing.Size(137, 17);
            this.chkPago.TabIndex = 12;
            this.chkPago.Text = "Pago Contado o Debito";
            this.chkPago.UseVisualStyleBackColor = true;
            // 
            // chkCasco
            // 
            this.chkCasco.AutoSize = true;
            this.chkCasco.Location = new System.Drawing.Point(11, 19);
            this.chkCasco.Name = "chkCasco";
            this.chkCasco.Size = new System.Drawing.Size(87, 17);
            this.chkCasco.TabIndex = 10;
            this.chkCasco.Text = "Incluir Casco";
            this.chkCasco.UseVisualStyleBackColor = true;
            // 
            // chkProtecciones
            // 
            this.chkProtecciones.AutoSize = true;
            this.chkProtecciones.Location = new System.Drawing.Point(11, 42);
            this.chkProtecciones.Name = "chkProtecciones";
            this.chkProtecciones.Size = new System.Drawing.Size(119, 17);
            this.chkProtecciones.TabIndex = 11;
            this.chkProtecciones.Text = "Incluir Protecciones";
            this.chkProtecciones.UseVisualStyleBackColor = true;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(27, 106);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "Dias";
            // 
            // lblTipodeBicicleta
            // 
            this.lblTipodeBicicleta.AutoSize = true;
            this.lblTipodeBicicleta.Location = new System.Drawing.Point(27, 73);
            this.lblTipodeBicicleta.Name = "lblTipodeBicicleta";
            this.lblTipodeBicicleta.Size = new System.Drawing.Size(86, 13);
            this.lblTipodeBicicleta.TabIndex = 4;
            this.lblTipodeBicicleta.Text = "Tipo de Bicicleta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre del Cliente";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(352, 73);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 37);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(352, 128);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 37);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(352, 19);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 37);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 515);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.mrcTipo);
            this.Controls.Add(this.mrcRegistroDeAlquileres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.mrcTipo.ResumeLayout(false);
            this.mrcTipo.PerformLayout();
            this.mrcRegistroDeAlquileres.ResumeLayout(false);
            this.mrcRegistroDeAlquileres.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox mrcTipo;
        private System.Windows.Forms.RadioButton optMountain;
        private System.Windows.Forms.RadioButton optTodos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox mrcRegistroDeAlquileres;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.ComboBox comboBoxTipoBicicleta;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.CheckBox chkPago;
        private System.Windows.Forms.CheckBox chkCasco;
        private System.Windows.Forms.CheckBox chkProtecciones;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblTipodeBicicleta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalcular;
    }
}

