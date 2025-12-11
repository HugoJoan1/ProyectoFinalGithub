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
			this.listView1 = new System.Windows.Forms.ListView();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.ImporteNeto = new System.Windows.Forms.TextBox();
			this.ImportePagado = new System.Windows.Forms.TextBox();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmbProductos = new System.Windows.Forms.ComboBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(11, 273);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(701, 183);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.Location = new System.Drawing.Point(11, 459);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(91, 22);
			this.lblSubtotal.TabIndex = 1;
			this.lblSubtotal.Text = "Subtotal: ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(227, 459);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Descuento: ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(462, 464);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "Importe Neto: ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(462, 492);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Importe Pagado: ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(462, 521);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 22);
			this.label4.TabIndex = 5;
			this.label4.Text = "Cambio: ";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(94, 459);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(129, 27);
			this.txtSubtotal.TabIndex = 6;
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(328, 459);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(129, 27);
			this.txtDescuento.TabIndex = 7;
			// 
			// ImporteNeto
			// 
			this.ImporteNeto.Location = new System.Drawing.Point(584, 459);
			this.ImporteNeto.Name = "ImporteNeto";
			this.ImporteNeto.Size = new System.Drawing.Size(128, 27);
			this.ImporteNeto.TabIndex = 8;
			// 
			// ImportePagado
			// 
			this.ImportePagado.Location = new System.Drawing.Point(584, 489);
			this.ImportePagado.Name = "ImportePagado";
			this.ImportePagado.Size = new System.Drawing.Size(128, 27);
			this.ImportePagado.TabIndex = 9;
			// 
			// txtCambio
			// 
			this.txtCambio.Location = new System.Drawing.Point(584, 518);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(128, 27);
			this.txtCambio.TabIndex = 10;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.White;
			this.btnGuardar.ForeColor = System.Drawing.Color.Black;
			this.btnGuardar.Location = new System.Drawing.Point(12, 505);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(114, 38);
			this.btnGuardar.TabIndex = 11;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			// 
			// btnBorrar
			// 
			this.btnBorrar.BackColor = System.Drawing.Color.White;
			this.btnBorrar.ForeColor = System.Drawing.Color.Black;
			this.btnBorrar.Location = new System.Drawing.Point(131, 505);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(114, 38);
			this.btnBorrar.TabIndex = 12;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = false;
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.White;
			this.btnImprimir.ForeColor = System.Drawing.Color.Black;
			this.btnImprimir.Location = new System.Drawing.Point(250, 505);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(114, 38);
			this.btnImprimir.TabIndex = 13;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(535, 229);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(169, 38);
			this.button4.TabIndex = 14;
			this.button4.Text = "Agregar Producto";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.White;
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Location = new System.Drawing.Point(535, 185);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(169, 38);
			this.button5.TabIndex = 15;
			this.button5.Text = "Borrar Producto";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(205, 201);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 22);
			this.label5.TabIndex = 16;
			this.label5.Text = "Total: ";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 201);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 22);
			this.label6.TabIndex = 17;
			this.label6.Text = "Precio: ";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(109, 201);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 22);
			this.label7.TabIndex = 18;
			this.label7.Text = "Cantidad: ";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(12, 240);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(91, 27);
			this.txtPrecio.TabIndex = 19;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(108, 240);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(91, 27);
			this.txtCantidad.TabIndex = 20;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(205, 240);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(91, 27);
			this.txtTotal.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(11, 169);
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
			this.pictureBox2.Location = new System.Drawing.Point(710, 155);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(85, 85);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 25;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// cmbProductos
			// 
			this.cmbProductos.FormattingEnabled = true;
			this.cmbProductos.Location = new System.Drawing.Point(191, 166);
			this.cmbProductos.Name = "cmbProductos";
			this.cmbProductos.Size = new System.Drawing.Size(148, 29);
			this.cmbProductos.TabIndex = 26;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.White;
			this.btnSalir.ForeColor = System.Drawing.Color.Black;
			this.btnSalir.Location = new System.Drawing.Point(12, 549);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(114, 38);
			this.btnSalir.TabIndex = 27;
			this.btnSalir.Text = "Imprimir";
			this.btnSalir.UseVisualStyleBackColor = false;
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
			// Pasteleria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(800, 749);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.cmbProductos);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.ImportePagado);
			this.Controls.Add(this.ImporteNeto);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblSubtotal);
			this.Controls.Add(this.listView1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
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
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.ComboBox cmbProductos;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.TextBox ImportePagado;
		private System.Windows.Forms.TextBox ImporteNeto;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.ListView listView1;
	}
}
