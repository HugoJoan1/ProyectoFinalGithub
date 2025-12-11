/*
 * Creado por SharpDevelop.
 * Usuario: Abelg
 * Fecha: 12/8/2025
 * Hora: 2:32 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trabajo14
{
	/// <summary>
	/// Description of Pasteleria.
	/// </summary>
	public partial class Pasteleria : Form
	{
		public Pasteleria()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PasteleriaLoad(object sender, EventArgs e)
		{
			
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			this.Close();
			Main mn=new Main();
			mn.Show();
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;			
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hugo, ayúdame a terminar el código de esta vaina (boleta). Luis ya debería de tener casi listo el de Empleados y también falta acabar lo de Boleta, por el símbolo de infinito. Voy al baño.");
		}
	}
}
