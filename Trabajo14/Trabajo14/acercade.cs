/*
 * Creado por SharpDevelop.
 * Usuario: Abelg
 * Fecha: 12/11/2025
 * Hora: 1:20 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trabajo14
{
	/// <summary>
	/// Description of acercade.
	/// </summary>
	public partial class acercade : Form
	{
		public acercade()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncerrarClick(object sender, EventArgs e)
		{
			this.Close();
			Main n=new Main();
			n.Show();
		}
	}
}
