/*
 * Created by SharpDevelop.
 * User: Abelg
 * Date: 10/1/2025
 * Time: 12:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Trabajo14
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		[DllImport("user32.DLL",EntryPoint="ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL",EntryPoint="SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd,
		                                       int wmsg, int wparam, int lparam);
		void TxtUserEnter(object sender, EventArgs e)
		{
		//Cuando el cursor esta dentro de la caja de texto:
			if(txtUser.Text=="USUARIO")
			{
			txtUser.Text="";
			txtUser.ForeColor=Color.LightGray;
			}
		}
		
		void TxtUserLeave(object sender, EventArgs e)
		{
		//Cuando el cursor sale de la caja de texto:
			if(txtUser.Text=="")
			{
			txtUser.Text="USUARIO";
			txtUser.ForeColor=Color.DimGray;
			}
		}
		
		void TxtPassEnter(object sender, EventArgs e)
		{
			if(txtPass.Text=="CONTRASEÑA")
			{
				txtPass.Text="";
				txtPass.ForeColor=Color.LightGray;
				txtPass.UseSystemPasswordChar=true;
			}
		}
		
		void TxtPassLeave(object sender, EventArgs e)
		{
			if(txtPass.Text=="")
			{
				txtPass.Text="CONTRASEÑA";
				txtPass.ForeColor=Color.DimGray;
				txtPass.UseSystemPasswordChar=false;
			}	
		}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnMinimizarClick(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;			
		}

		int intentosFallidos = 0;
		void BtnAccederClick(object sender, EventArgs e)
		{
    		if(txtPass.Text == "1234" && txtUser.Text == "Usuario")
    	{
    		//Mensaje de bienvenida.
    		MessageBox.Show("Bienvenido","Bienvenido",
    		MessageBoxButtons.OK,
    		MessageBoxIcon.Asterisk
    					   );
    		//Formulario.
	        Main mn=new Main();
	        mn.Show();
	        this.Hide();
    	}
    		else
    		{
        		intentosFallidos++;       
		        MessageBox.Show(
        	    "Usuario o contraseña incorrectos.\n Intento " + intentosFallidos + " de 3",
        	    "Error",
        	    MessageBoxButtons.OK,
        	    MessageBoxIcon.Error
        	);
        	if (intentosFallidos >= 3)
        		{
        		    MessageBox.Show(
        	        "Has superado el número de intentos permitidos.\n El programa se cerrará.",
        	        "Advertencia",
        	        MessageBoxButtons.OK,
        	        MessageBoxIcon.Warning
        	    );
        	    Application.Exit();
       			}
    		}
		}
		
		void LinkPassLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Usuario: Usuario \n Contraseña: 1234");
		}
	}
}