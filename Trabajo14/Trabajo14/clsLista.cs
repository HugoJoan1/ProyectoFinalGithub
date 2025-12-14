/*
 * Created by SharpDevelop.
 * User: CC1_PC11
 * Date: 11/12/2025
 * Time: 02:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace Trabajo14
{
	/// <summary>
	/// Description of clsLista.
	/// </summary>
	public class clsLista
	{	public string Nombre {get; set;}
		public int Codigo {get; set;}
		public string Sexo {get; set;}
		public string Puesto {get; set;}
		public DateTime Fecha { get; set; }
		public string Estado { get; set; }
		public Image Imagen { get; set; }
		public clsLista()
		{
		}
	}
}
