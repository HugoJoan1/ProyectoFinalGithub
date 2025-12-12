/*
 * Creado por SharpDevelop.
 * Usuario: Abelg
 * Fecha: 12/8/2025
 * Hora: 6:40 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Trabajo14
{
	partial class Boleta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boleta));
			this.lvCali = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.cboMateria = new System.Windows.Forms.ComboBox();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cboEspecialidad = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboGrado = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtParcial3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtParcial2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtParcial1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbltitulo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.lblGeneral = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lvCali
			// 
			this.lvCali.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.lvCali.Location = new System.Drawing.Point(12, 304);
			this.lvCali.Name = "lvCali";
			this.lvCali.Size = new System.Drawing.Size(560, 133);
			this.lvCali.TabIndex = 41;
			this.lvCali.UseCompatibleStateImageBehavior = false;
			this.lvCali.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Asignatura o Submódulo";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Parcial 1";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Parcial 2";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Parcial 3";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Promedio";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Aprobado/Desaprobado";
			this.columnHeader6.Width = 144;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Location = new System.Drawing.Point(450, 261);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(81, 23);
			this.btnSalir.TabIndex = 40;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancelar.ForeColor = System.Drawing.Color.White;
			this.btnCancelar.Location = new System.Drawing.Point(346, 261);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(81, 23);
			this.btnCancelar.TabIndex = 39;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = false;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegistrar.Location = new System.Drawing.Point(250, 261);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(81, 23);
			this.btnRegistrar.TabIndex = 38;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// cboMateria
			// 
			this.cboMateria.FormattingEnabled = true;
			this.cboMateria.Items.AddRange(new object[] {
									"Ingles",
									"Matematicas",
									"Ecosistemas (Biologia)",
									"Emplea Frameworks",
									"Metodologias agiles",
									"Humanidades",
									"Lengua y Comunicación"});
			this.cboMateria.Location = new System.Drawing.Point(46, 217);
			this.cboMateria.Name = "cboMateria";
			this.cboMateria.Size = new System.Drawing.Size(143, 21);
			this.cboMateria.TabIndex = 35;
			// 
			// lblFecha
			// 
			this.lblFecha.BackColor = System.Drawing.Color.White;
			this.lblFecha.Location = new System.Drawing.Point(346, 214);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(69, 21);
			this.lblFecha.TabIndex = 37;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(346, 197);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 17);
			this.label7.TabIndex = 36;
			this.label7.Text = "Fecha Actual:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(59, 197);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 17);
			this.label6.TabIndex = 34;
			this.label6.Text = "Asignatura o Submódulo:";
			// 
			// cboEspecialidad
			// 
			this.cboEspecialidad.FormattingEnabled = true;
			this.cboEspecialidad.Items.AddRange(new object[] {
									"Programación",
									"Contabilidad",
									"Alimentos",
									"Administración",
									"Soporte",
									"Ofimatica",
									"CiberSeguridad",
									"Mecanica"});
			this.cboEspecialidad.Location = new System.Drawing.Point(333, 148);
			this.cboEspecialidad.Name = "cboEspecialidad";
			this.cboEspecialidad.Size = new System.Drawing.Size(143, 21);
			this.cboEspecialidad.TabIndex = 33;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(246, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 17);
			this.label5.TabIndex = 32;
			this.label5.Text = "Especialidad:";
			// 
			// cboGrado
			// 
			this.cboGrado.FormattingEnabled = true;
			this.cboGrado.Items.AddRange(new object[] {
									"1",
									"2",
									"3"});
			this.cboGrado.Location = new System.Drawing.Point(125, 148);
			this.cboGrado.Name = "cboGrado";
			this.cboGrado.Size = new System.Drawing.Size(41, 21);
			this.cboGrado.TabIndex = 31;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(79, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 17);
			this.label4.TabIndex = 30;
			this.label4.Text = "Grado: ";
			// 
			// txtParcial3
			// 
			this.txtParcial3.Location = new System.Drawing.Point(450, 101);
			this.txtParcial3.Name = "txtParcial3";
			this.txtParcial3.Size = new System.Drawing.Size(26, 20);
			this.txtParcial3.TabIndex = 29;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(439, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 17);
			this.label3.TabIndex = 28;
			this.label3.Text = "Parcial 3";
			// 
			// txtParcial2
			// 
			this.txtParcial2.Location = new System.Drawing.Point(364, 101);
			this.txtParcial2.Name = "txtParcial2";
			this.txtParcial2.Size = new System.Drawing.Size(26, 20);
			this.txtParcial2.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(353, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 17);
			this.label2.TabIndex = 26;
			this.label2.Text = "Parcial 2";
			// 
			// txtParcial1
			// 
			this.txtParcial1.Location = new System.Drawing.Point(278, 101);
			this.txtParcial1.Name = "txtParcial1";
			this.txtParcial1.Size = new System.Drawing.Size(26, 20);
			this.txtParcial1.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(267, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 17);
			this.label1.TabIndex = 24;
			this.label1.Text = "Parcial 1";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(46, 101);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(143, 20);
			this.txtNombre.TabIndex = 23;
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(66, 81);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(100, 17);
			this.lbl1.TabIndex = 22;
			this.lbl1.Text = "Nombre del alumno";
			// 
			// lbltitulo
			// 
			this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltitulo.Location = new System.Drawing.Point(66, 24);
			this.lbltitulo.Name = "lbltitulo";
			this.lbltitulo.Size = new System.Drawing.Size(450, 27);
			this.lbltitulo.TabIndex = 21;
			this.lbltitulo.Text = "BOLETA DE CALIFICACIONES";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(534, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 42;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(557, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(27, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 43;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(353, 451);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(107, 18);
			this.label8.TabIndex = 44;
			this.label8.Text = "Calificacion General:";
			// 
			// lblGeneral
			// 
			this.lblGeneral.Location = new System.Drawing.Point(463, 446);
			this.lblGeneral.Name = "lblGeneral";
			this.lblGeneral.Size = new System.Drawing.Size(100, 23);
			this.lblGeneral.TabIndex = 45;
			this.lblGeneral.Text = " [texto]";
			this.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblGeneral.Click += new System.EventHandler(this.LblGeneralClick);
			// 
			// Boleta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(584, 478);
			this.Controls.Add(this.lblGeneral);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lvCali);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.cboMateria);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cboEspecialidad);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboGrado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtParcial3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtParcial2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtParcial1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.lbltitulo);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Boleta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Boleta";
			this.Load += new System.EventHandler(this.BoletaLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblGeneral;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbltitulo;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtParcial1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtParcial2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtParcial3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboGrado;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboEspecialidad;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.ComboBox cboMateria;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvCali;
	}
}
