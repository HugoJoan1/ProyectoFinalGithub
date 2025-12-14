/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 12/14/2025
 * Time: 2:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trabajo14
{
	/// <summary>
	/// Description of yuppie.
	/// </summary>
	public partial class yuppie : Form
	{
		public yuppie()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Esta seguro que desea volver a Empleados?","Confirmar salir",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
			{
			Empleado j=new Empleado();
			j.Show();
			this.Close();
			}
		}
		
		void YuppieLoad(object sender, EventArgs e)
		{
			
		}
	}
}
