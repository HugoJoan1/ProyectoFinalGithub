/*
 * Creado por SharpDevelop.
 * Usuario: Abelg
 * Fecha: 12/8/2025
 * Hora: 3:29 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trabajo14
{
	/// <summary>
	/// Description of Main.
	/// </summary>
	public partial class Main : Form
	{
		double area;
		double volumen;
		double perimetro;
		
		public Main()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;			
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Seguro que desea salir?","Confirmar Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
			  Application.Exit();
			}			
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Seguro que desea salir?","Confirmar Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
			  Application.Exit();
			}			
		}
		private void SetMdiBackColor(Color color)
		{
    		foreach (Control ctrl in this.Controls)
    	{
        	if (ctrl is MdiClient)
        		{
        		    ctrl.BackColor = color;
       			}
    		}
		}	
		
		void MainLoad(object sender, EventArgs e)
		{
    		SetMdiBackColor(Color.FromArgb(15, 15, 15));			
		}
		void KilometrosAMillasToolStripMenuItemClick(object sender, EventArgs e)
		{
			double Kilo,Millas;
			Kilo=Convert.ToDouble(textBox1.Text);
			Millas=Convert.ToDouble(textBox2.Text);
			Millas = Kilo * 0.621371;
			lblResultado.Text = Millas.ToString();			
		}
		
		void KilogramosALToolStripMenuItemClick(object sender, EventArgs e)
		{
			double Kilo,libras;
			Kilo=Convert.ToDouble(textBox1.Text);
			libras=Convert.ToDouble(textBox2.Text);
			libras = Kilo * 2.20462;	
			lblResultado.Text = libras.ToString();			
		}
		
		void CelciusAFahrenheitToolStripMenuItemClick(object sender, EventArgs e)
		{
			double temp1,temp2;
			temp1=Convert.ToDouble(textBox1.Text);
			temp2 = (temp1 * 9/5) + 32;
			lblResultado.Text = temp2.ToString();	
		}
		
		void SegundosAHorasToolStripMenuItemClick(object sender, EventArgs e)
		{
			double seg,horas;
			seg=Convert.ToDouble(textBox1.Text);			
			horas = seg / 3600;
			lblResultado.Text = horas.ToString();			
		}
		
		void FactorialToolStripMenuItemClick(object sender, EventArgs e)
		{
			int factorial,resu;
			factorial=Convert.ToInt32(textBox1.Text);
			resu = 1;
			for(int i = 1; i <= factorial; i++)
			{
					resu = resu * i;
			}
			lblResultado.Text = resu.ToString();			
		}
		
		void FibonacciToolStripMenuItemClick(object sender, EventArgs e)
		{
			lblResultado.Text = "0,1,1,2,3,5,8,13,21,34,55,39,144,233,377,610,987,1597";			
		}
		
		void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
			double lados;
			lados=Convert.ToDouble(textBox1.Text);
			area = lados * lados;
			lblResultado.Text = area.ToString();			
		}
		
		void RectánguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			double lado,altura;
			lado=Convert.ToDouble(textBox1.Text);
			altura=Convert.ToDouble(textBox2.Text);
			area = lado * altura;
			lblResultado.Text = area.ToString();			
		}
		
		void TriánguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			double lado,altura;
			lado=Convert.ToDouble(textBox1.Text);
			altura=Convert.ToDouble(textBox2.Text);
			area = (lado * altura) / 2;
			lblResultado.Text = area.ToString();			
		}
		
		void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
		{
			double radio;
			radio=Convert.ToDouble(textBox2.Text);
			perimetro = 2 * 3.1416 * radio;
			lblResultado.Text = perimetro.ToString();			
		}
		
		void TrapecioToolStripMenuItemClick(object sender, EventArgs e)
		{
			double a,b,c,d;
			a=Convert.ToDouble(textBox1.Text);
			b=Convert.ToDouble(textBox2.Text);
			c=Convert.ToDouble(textBox3.Text);
			d=Convert.ToDouble(textBox4.Text);
			perimetro = a + b + c + d;
			lblResultado.Text = perimetro.ToString();			
		}
		
		void EsferaToolStripMenuItemClick(object sender, EventArgs e)
		{
			double radio;
			radio=Convert.ToDouble(textBox2.Text);
			volumen = (4/3) * 3.1416 * (radio * radio * radio);
			lblResultado.Text = volumen.ToString();			
		}
		
		void CuboToolStripMenuItemClick(object sender, EventArgs e)
		{
			double lado;
			lado=Convert.ToDouble(textBox1.Text);
			volumen = lado * lado * lado;
			lblResultado.Text = volumen.ToString();			
		}
		
		void PiramideToolStripMenuItemClick(object sender, EventArgs e)
		{
    		try
    	{
        	double baseLado, altura;
	        baseLado = Convert.ToDouble(textBox1.Text);
    	    altura   = Convert.ToDouble(textBox2.Text);
	        volumen = (baseLado * baseLado * altura) / 3;
	        lblResultado.Text = volumen.ToString();
    	}
    			catch
   		{
        	MessageBox.Show(
            "Por favor ingrese valores numéricos válidos.",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        		);
    		}
		}
		void PasteleríayPostresToolStripMenuItemClick(object sender, EventArgs e)
		{
			Pasteleria pas=new Pasteleria();
			pas.Show();
			this.Hide();
		}
		
		void EmpleadoToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Empleado emp=new Empleado();
			emp.Show();
			this.Hide();
		}
		
		void BoletaDeCalificacionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Boleta bol=new Boleta();
			bol.Show();
			this.Hide();
		}
	}
}