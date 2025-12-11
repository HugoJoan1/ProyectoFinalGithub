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
		
		int i;
		double General = 0;
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			this.Close();
			Main mn=new Main();
			mn.Show();
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			double p1=Convert.ToDouble(txtParcial1.Text);
            double p2=Convert.ToDouble(txtParcial2.Text);
            double p3=Convert.ToDouble(txtParcial3.Text);
            string Grado = cboGrado.Text;
            string Especialidad = cboEspecialidad.Text;
            string Materia = cboMateria.Text;
            
            string A;
            
            double Promedio = p1 + p2 + p3;
            Promedio = Promedio / 3;
            
            if(Promedio >= 6)
            {
            
                A = "Aprobado";
            
            }
            else
            {
            
                A = "Desaprobado";
            
            }
            
            ListViewItem fila= new ListViewItem(Materia);
            
            fila.SubItems.Add(p1.ToString());
                        
            fila.SubItems.Add(p2.ToString());
            
            fila.SubItems.Add(p3.ToString());
            

            fila.SubItems.Add(Promedio.ToString());
                        
            fila.SubItems.Add(A);
                      
                        
            lvCali.Items.Add(fila);
            
            
            
            General = General + Promedio;
            General = General / i;
            lblGeneral.Text=General.ToString();
            
            i = 2;		
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
			Main mn=new Main();
			mn.Show();
		}
		
		void BoletaLoad(object sender, EventArgs e)
		{
			lblFecha.Text=DateTime.Today.Date.ToString("d");			
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;			
		}
		
		void LblGeneralClick(object sender, EventArgs e)
		{
			
		}
	}
}
