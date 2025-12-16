/*
 * Creado por SharpDevelop.
 * Usuario: Abelg
 * Fecha: 12/8/2025
 * Hora: 2:33 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Trabajo14
{
	partial class Empleado
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
			this.lblSa = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.gpbEstado = new System.Windows.Forms.GroupBox();
			this.rbnContrato = new System.Windows.Forms.RadioButton();
			this.rbnRegular = new System.Windows.Forms.RadioButton();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbPuesto = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.LBLE = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.picImagen = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.limpiarTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarLaApplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.txtRutaArchivo = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.gpbEstado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSa
			// 
			this.lblSa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSa.Location = new System.Drawing.Point(80, 278);
			this.lblSa.Name = "lblSa";
			this.lblSa.Size = new System.Drawing.Size(224, 23);
			this.lblSa.TabIndex = 66;
			this.lblSa.Text = "ruta de la imagen";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(749, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 21);
			this.button1.TabIndex = 65;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(429, 602);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(129, 36);
			this.btnLimpiar.TabIndex = 63;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// gpbEstado
			// 
			this.gpbEstado.Controls.Add(this.rbnContrato);
			this.gpbEstado.Controls.Add(this.rbnRegular);
			this.gpbEstado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbEstado.Location = new System.Drawing.Point(23, 239);
			this.gpbEstado.Name = "gpbEstado";
			this.gpbEstado.Size = new System.Drawing.Size(266, 20);
			this.gpbEstado.TabIndex = 57;
			this.gpbEstado.TabStop = false;
			this.gpbEstado.Text = "Estado:";
			// 
			// rbnContrato
			// 
			this.rbnContrato.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnContrato.Location = new System.Drawing.Point(177, 0);
			this.rbnContrato.Name = "rbnContrato";
			this.rbnContrato.Size = new System.Drawing.Size(104, 24);
			this.rbnContrato.TabIndex = 12;
			this.rbnContrato.TabStop = true;
			this.rbnContrato.Text = "Contrato";
			this.rbnContrato.UseVisualStyleBackColor = true;
			// 
			// rbnRegular
			// 
			this.rbnRegular.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnRegular.Location = new System.Drawing.Point(83, 0);
			this.rbnRegular.Name = "rbnRegular";
			this.rbnRegular.Size = new System.Drawing.Size(88, 24);
			this.rbnRegular.TabIndex = 11;
			this.rbnRegular.TabStop = true;
			this.rbnRegular.Text = "Regular";
			this.rbnRegular.UseVisualStyleBackColor = true;
			// 
			// cmbSexo
			// 
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
									"Hombre",
									"Mujer"});
			this.cmbSexo.Location = new System.Drawing.Point(115, 202);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(144, 21);
			this.cmbSexo.TabIndex = 56;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(49, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 23);
			this.label5.TabIndex = 55;
			this.label5.Text = "Sexo:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(222, 145);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(98, 20);
			this.dtpFecha.TabIndex = 54;
			this.dtpFecha.Value = new System.DateTime(2025, 12, 14, 0, 0, 0, 0);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(197, 23);
			this.label4.TabIndex = 53;
			this.label4.Text = "Fecha De Nacimento";
			// 
			// cmbPuesto
			// 
			this.cmbPuesto.FormattingEnabled = true;
			this.cmbPuesto.Items.AddRange(new object[] {
									"Cajero",
									"Migajero (Rafa)",
									"Gerente",
									"Ingeniero",
									"Conserje"});
			this.cmbPuesto.Location = new System.Drawing.Point(115, 178);
			this.cmbPuesto.Name = "cmbPuesto";
			this.cmbPuesto.Size = new System.Drawing.Size(144, 21);
			this.cmbPuesto.TabIndex = 52;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 23);
			this.label3.TabIndex = 51;
			this.label3.Text = "Puesto:";
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Location = new System.Drawing.Point(222, 88);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(542, 20);
			this.txtNombre.TabIndex = 50;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(30, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 23);
			this.label2.TabIndex = 49;
			this.label2.Text = "Nombre Del Empleado:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodigo.Location = new System.Drawing.Point(222, 118);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(542, 20);
			this.txtCodigo.TabIndex = 47;
			// 
			// LBLE
			// 
			this.LBLE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLE.Location = new System.Drawing.Point(30, 116);
			this.LBLE.Name = "LBLE";
			this.LBLE.Size = new System.Drawing.Size(197, 23);
			this.LBLE.TabIndex = 46;
			this.LBLE.Text = "Codigo Del Empleado:";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(241, 602);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(129, 36);
			this.btnEliminar.TabIndex = 62;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(32, 602);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(132, 36);
			this.btnGuardar.TabIndex = 48;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnQuitar
			// 
			this.btnQuitar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuitar.Location = new System.Drawing.Point(67, 360);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(162, 24);
			this.btnQuitar.TabIndex = 61;
			this.btnQuitar.Text = "Quitar imagen";
			this.btnQuitar.UseVisualStyleBackColor = true;
			this.btnQuitar.Click += new System.EventHandler(this.BtnQuitarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(287, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Detalles del empleado";
			// 
			// btnActualizar
			// 
			this.btnActualizar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(67, 330);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(162, 24);
			this.btnActualizar.TabIndex = 60;
			this.btnActualizar.Text = "Actualizar imagen";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// picImagen
			// 
			this.picImagen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picImagen.Location = new System.Drawing.Point(363, 147);
			this.picImagen.Name = "picImagen";
			this.picImagen.Size = new System.Drawing.Size(387, 252);
			this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picImagen.TabIndex = 59;
			this.picImagen.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-15, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 49);
			this.panel1.TabIndex = 45;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(781, 24);
			this.menuStrip1.TabIndex = 64;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.limpiarTextoToolStripMenuItem,
									this.toolStripMenuItem2,
									this.volverToolStripMenuItem,
									this.cerrarLaApplicacionToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// limpiarTextoToolStripMenuItem
			// 
			this.limpiarTextoToolStripMenuItem.Name = "limpiarTextoToolStripMenuItem";
			this.limpiarTextoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.limpiarTextoToolStripMenuItem.Text = "&Limpiar &Texto";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 22);
			this.toolStripMenuItem2.Text = "---------------------------";
			// 
			// volverToolStripMenuItem
			// 
			this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
			this.volverToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.volverToolStripMenuItem.Text = "&Volver";
			// 
			// cerrarLaApplicacionToolStripMenuItem
			// 
			this.cerrarLaApplicacionToolStripMenuItem.Name = "cerrarLaApplicacionToolStripMenuItem";
			this.cerrarLaApplicacionToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.cerrarLaApplicacionToolStripMenuItem.Text = "&Cerrar la applicacion";
			this.cerrarLaApplicacionToolStripMenuItem.Click += new System.EventHandler(this.CerrarLaApplicacionToolStripMenuItemClick);
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// dgvDatos
			// 
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Location = new System.Drawing.Point(12, 405);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.Size = new System.Drawing.Size(622, 191);
			this.dgvDatos.TabIndex = 58;
			// 
			// txtRutaArchivo
			// 
			this.txtRutaArchivo.Location = new System.Drawing.Point(56, 304);
			this.txtRutaArchivo.Name = "txtRutaArchivo";
			this.txtRutaArchivo.Size = new System.Drawing.Size(264, 20);
			this.txtRutaArchivo.TabIndex = 67;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(255, 330);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(65, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 68;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(640, 416);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(124, 83);
			this.btnAgregar.TabIndex = 69;
			this.btnAgregar.Text = "AGREGAR A BASE DE DATOS";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(640, 517);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(124, 79);
			this.button3.TabIndex = 70;
			this.button3.Text = "ELIMINAR DE BASE DE DATOS";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label6.Location = new System.Drawing.Point(592, 599);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(189, 45);
			this.label6.TabIndex = 71;
			this.label6.Text = "Ponga los datos correspondientes del empleado que desee eliminar en el formulario" +
			".";
			// 
			// Empleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(781, 650);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblSa);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.gpbEstado);
			this.Controls.Add(this.cmbSexo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbPuesto);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.LBLE);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.picImagen);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.dgvDatos);
			this.Controls.Add(this.txtRutaArchivo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Empleado";
			this.Opacity = 0.94D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Empleado";
			this.gpbEstado.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
			this.panel1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.ToolStripMenuItem cerrarLaApplicacionToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtRutaArchivo;
		private System.Windows.Forms.DataGridView dgvDatos;
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem limpiarTextoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picImagen;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label LBLE;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbPuesto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.RadioButton rbnRegular;
		private System.Windows.Forms.RadioButton rbnContrato;
		private System.Windows.Forms.GroupBox gpbEstado;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblSa;
	}
}
