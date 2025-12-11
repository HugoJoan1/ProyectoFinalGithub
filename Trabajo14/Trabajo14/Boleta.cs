/*
 * Creado por SharpDevelop.
 * Usuario: Abelg
 * Fecha: 12/8/2025
 * Hora: 6:40 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trabajo14
{
	/// <summary>
	/// Description of Boleta.
	/// </summary>
	public partial class Boleta : Form
	{
		public Boleta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			this.Close();
			Main mn=new Main();
			mn.Show();
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			double cantidad=Convert.ToDouble(txtParcial1.Text);			
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
			Main mn=new Main();
			mn.Show();
		}
		
		void BoletaLoad(object sender, EventArgs e)
		{
			label8.Text=DateTime.Today.Date.ToString("d");			
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;			
		}
	}
}
