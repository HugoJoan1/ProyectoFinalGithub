/*
 * Creado por SharpDevelop.
 * Usuario: Abelg
 * Fecha: 12/8/2025
 * Hora: 2:32 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Trabajo14
{
	partial class Pasteleria
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pasteleria));
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.txtImporteNeto = new System.Windows.Forms.TextBox();
			this.txtImportePagado = new System.Windows.Forms.TextBox();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.btnGuardarSQL = new System.Windows.Forms.Button();
			this.btnBorrarSQL = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnBorrarProducto = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmbProducto = new System.Windows.Forms.ComboBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.rdbDulce = new System.Windows.Forms.RadioButton();
			this.rdbSalado = new System.Windows.Forms.RadioButton();
			this.DGVProductos = new System.Windows.Forms.DataGridView();
			this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.Location = new System.Drawing.Point(9, 527);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(91, 22);
			this.lblSubtotal.TabIndex = 1;
			this.lblSubtotal.Text = "Subtotal: ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(225, 527);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Descuento: ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(533, 532);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "Importe Neto: ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(510, 560);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Importe Pagado: ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(568, 589);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 22);
			this.label4.TabIndex = 5;
			this.label4.Text = "Cambio: ";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(92, 527);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(129, 27);
			this.txtSubtotal.TabIndex = 6;
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(326, 527);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(129, 27);
			this.txtDescuento.TabIndex = 7;
			// 
			// txtImporteNeto
			// 
			this.txtImporteNeto.Location = new System.Drawing.Point(655, 527);
			this.txtImporteNeto.Name = "txtImporteNeto";
			this.txtImporteNeto.Size = new System.Drawing.Size(128, 27);
			this.txtImporteNeto.TabIndex = 8;
			// 
			// txtImportePagado
			// 
			this.txtImportePagado.Location = new System.Drawing.Point(655, 557);
			this.txtImportePagado.Name = "txtImportePagado";
			this.txtImportePagado.Size = new System.Drawing.Size(128, 27);
			this.txtImportePagado.TabIndex = 9;
			// 
			// txtCambio
			// 
			this.txtCambio.Location = new System.Drawing.Point(655, 586);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(128, 27);
			this.txtCambio.TabIndex = 10;
			// 
			// btnGuardarSQL
			// 
			this.btnGuardarSQL.BackColor = System.Drawing.Color.White;
			this.btnGuardarSQL.ForeColor = System.Drawing.Color.Black;
			this.btnGuardarSQL.Location = new System.Drawing.Point(10, 573);
			this.btnGuardarSQL.Name = "btnGuardarSQL";
			this.btnGuardarSQL.Size = new System.Drawing.Size(114, 112);
			this.btnGuardarSQL.TabIndex = 11;
			this.btnGuardarSQL.Text = "Guardar producto a base de datos";
			this.btnGuardarSQL.UseVisualStyleBackColor = false;
			this.btnGuardarSQL.Click += new System.EventHandler(this.BtnGuardarSQLClick);
			// 
			// btnBorrarSQL
			// 
			this.btnBorrarSQL.BackColor = System.Drawing.Color.White;
			this.btnBorrarSQL.ForeColor = System.Drawing.Color.Black;
			this.btnBorrarSQL.Location = new System.Drawing.Point(129, 573);
			this.btnBorrarSQL.Name = "btnBorrarSQL";
			this.btnBorrarSQL.Size = new System.Drawing.Size(114, 112);
			this.btnBorrarSQL.TabIndex = 12;
			this.btnBorrarSQL.Text = "Borrar producto de base de datos";
			this.btnBorrarSQL.UseVisualStyleBackColor = false;
			this.btnBorrarSQL.Click += new System.EventHandler(this.BtnBorrarSQLClick);
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.White;
			this.btnImprimir.ForeColor = System.Drawing.Color.Black;
			this.btnImprimir.Location = new System.Drawing.Point(248, 573);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(114, 38);
			this.btnImprimir.TabIndex = 13;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.BtnImprimirClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.White;
			this.btnAgregar.ForeColor = System.Drawing.Color.Black;
			this.btnAgregar.Location = new System.Drawing.Point(619, 257);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(169, 38);
			this.btnAgregar.TabIndex = 14;
			this.btnAgregar.Text = "Agregar Producto";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnBorrarProducto
			// 
			this.btnBorrarProducto.BackColor = System.Drawing.Color.White;
			this.btnBorrarProducto.ForeColor = System.Drawing.Color.Black;
			this.btnBorrarProducto.Location = new System.Drawing.Point(619, 297);
			this.btnBorrarProducto.Name = "btnBorrarProducto";
			this.btnBorrarProducto.Size = new System.Drawing.Size(169, 38);
			this.btnBorrarProducto.TabIndex = 15;
			this.btnBorrarProducto.Text = "Borrar Producto";
			this.btnBorrarProducto.UseVisualStyleBackColor = false;
			this.btnBorrarProducto.Click += new System.EventHandler(this.BtnBorrarProductoClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(203, 282);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 22);
			this.label5.TabIndex = 16;
			this.label5.Text = "Total: ";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(10, 282);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 22);
			this.label6.TabIndex = 17;
			this.label6.Text = "Precio: ";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(107, 282);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 22);
			this.label7.TabIndex = 18;
			this.label7.Text = "Cantidad: ";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(10, 308);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(91, 27);
			this.txtPrecio.TabIndex = 19;
			this.txtPrecio.TextChanged += new System.EventHandler(this.TxtPrecioTextChanged);
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(106, 308);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(91, 27);
			this.txtCantidad.TabIndex = 20;
			this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidadTextChanged);
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(203, 308);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(91, 27);
			this.txtTotal.TabIndex = 21;
			this.txtTotal.TextChanged += new System.EventHandler(this.TxtTotalTextChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(9, 237);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(193, 22);
			this.label8.TabIndex = 22;
			this.label8.Text = "Seleccionar Producto:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(800, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(715, 156);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(85, 85);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 25;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// cmbProducto
			// 
			this.cmbProducto.FormattingEnabled = true;
			this.cmbProducto.Items.AddRange(new object[] {
									"Pastel de Chocolate",
									"Cheesecake",
									"Cupcake",
									"Pay de limón",
									"Malteadas",
									"Empanada",
									"Croissant",
									"Quiche",
									"Pan de ajo",
									"Crepa Salada"});
			this.cmbProducto.Location = new System.Drawing.Point(189, 234);
			this.cmbProducto.Name = "cmbProducto";
			this.cmbProducto.Size = new System.Drawing.Size(244, 29);
			this.cmbProducto.TabIndex = 26;
			this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.CmbProductoSelectedIndexChanged);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.White;
			this.btnSalir.ForeColor = System.Drawing.Color.Black;
			this.btnSalir.Location = new System.Drawing.Point(368, 573);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(114, 38);
			this.btnSalir.TabIndex = 27;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(771, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(27, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 28;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.PictureBox3Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(745, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(29, 24);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 29;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.PictureBox4Click);
			// 
			// rdbDulce
			// 
			this.rdbDulce.Location = new System.Drawing.Point(286, 156);
			this.rdbDulce.Name = "rdbDulce";
			this.rdbDulce.Size = new System.Drawing.Size(147, 35);
			this.rdbDulce.TabIndex = 31;
			this.rdbDulce.TabStop = true;
			this.rdbDulce.Text = "Dulce";
			this.rdbDulce.UseVisualStyleBackColor = true;
			this.rdbDulce.CheckedChanged += new System.EventHandler(this.RdbDulceCheckedChanged);
			// 
			// rdbSalado
			// 
			this.rdbSalado.Location = new System.Drawing.Point(405, 156);
			this.rdbSalado.Name = "rdbSalado";
			this.rdbSalado.Size = new System.Drawing.Size(147, 35);
			this.rdbSalado.TabIndex = 32;
			this.rdbSalado.TabStop = true;
			this.rdbSalado.Text = "Salado";
			this.rdbSalado.UseVisualStyleBackColor = true;
			this.rdbSalado.CheckedChanged += new System.EventHandler(this.RdbSaladoCheckedChanged);
			// 
			// DGVProductos
			// 
			this.DGVProductos.AllowUserToAddRows = false;
			this.DGVProductos.BackgroundColor = System.Drawing.Color.White;
			this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Producto,
									this.Precio,
									this.Cantidad,
									this.Total});
			this.DGVProductos.GridColor = System.Drawing.Color.Black;
			this.DGVProductos.Location = new System.Drawing.Point(10, 341);
			this.DGVProductos.Name = "DGVProductos";
			this.DGVProductos.ReadOnly = true;
			this.DGVProductos.Size = new System.Drawing.Size(780, 180);
			this.DGVProductos.TabIndex = 33;
			// 
			// Producto
			// 
			this.Producto.FillWeight = 195F;
			this.Producto.Frozen = true;
			this.Producto.HeaderText = "Producto";
			this.Producto.Name = "Producto";
			this.Producto.ReadOnly = true;
			this.Producto.Width = 195;
			// 
			// Precio
			// 
			this.Precio.FillWeight = 195F;
			this.Precio.Frozen = true;
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			this.Precio.Width = 195;
			// 
			// Cantidad
			// 
			this.Cantidad.FillWeight = 195F;
			this.Cantidad.Frozen = true;
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			this.Cantidad.Width = 195;
			// 
			// Total
			// 
			this.Total.FillWeight = 195F;
			this.Total.Frozen = true;
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			this.Total.Width = 195;
			// 
			// Pasteleria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(800, 749);
			this.Controls.Add(this.DGVProductos);
			this.Controls.Add(this.rdbSalado);
			this.Controls.Add(this.rdbDulce);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.cmbProducto);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnBorrarProducto);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnBorrarSQL);
			this.Controls.Add(this.btnGuardarSQL);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.txtImportePagado);
			this.Controls.Add(this.txtImporteNeto);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblSubtotal);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Pasteleria";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pasteleria";
			this.Load += new System.EventHandler(this.PasteleriaLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
		private System.Windows.Forms.DataGridView DGVProductos;
		private System.Windows.Forms.RadioButton rdbSalado;
		private System.Windows.Forms.RadioButton rdbDulce;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.ComboBox cmbProducto;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnBorrarProducto;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnBorrarSQL;
		private System.Windows.Forms.Button btnGuardarSQL;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.TextBox txtImportePagado;
		private System.Windows.Forms.TextBox txtImporteNeto;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSubtotal;
	}
}
