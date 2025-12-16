/*
 * Creado por SharpDevelop.
 * Usuario: Abelg
 * Fecha: 12/8/2025
 * Hora: 2:33 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Trabajo14
{
/// <summary>
/// Description of Empleado.
/// </summary>
public partial class Empleado : Form	
	{
		BindingList<clsLista> miLista = new BindingList<clsLista>();

		public Empleado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			dgvDatos.AutoGenerateColumns = true;
			dgvDatos.DataSource = miLista;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Esta seguro que desea volver al menu?","Confirmar salir",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
			{
			Main n=new Main();
			n.Show();
			this.Close();
			}
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
  //EL btnGuardar es como el coco de Team Fortress si le mueven se petatea todo
  
	if (!ValidarNombre()) return;
	if (!ValidarCodigo()) return;
	if (!ValidarFecha()) return;
	if (!ValidarRaza()) return;
	if (!ValidarSexo()) return;
	if (!ValidarEstado()) return;
	if (!ValidarImagen()) return;
	
	if (ValidarNombre() == false)
    {
    	return;
    }

    if (ValidarCodigo() == false)
    {
    	return;
    }
    
    string estad = "Estado";
    if (rbnRegular.Checked)
    {
    	estad = "Regular";
    }
    else if (rbnContrato.Checked)
    {
    	estad = "Contrato";
    }

    	clsLista empleado = new clsLista();
    	empleado.Nombre = txtNombre.Text;
    	empleado.Codigo = int.Parse(txtCodigo.Text);
    	empleado.Puesto = cmbPuesto.SelectedItem.ToString();
    	empleado.Sexo = cmbSexo.SelectedItem.ToString();
    	empleado.Estado = estad;
    	empleado.Fecha = dtpFecha.Value;

    if (picImagen.Image != null)
    {
    	empleado.Imagen = picImagen.Image;
    }
    else
    {
    	empleado.Imagen = null;
    }
    	//Esto es para los errores que daba el DataDrifView, sobretodo el picturebox
    	miLista.Add(empleado);
    	dgvDatos.AutoGenerateColumns = true;
		dgvDatos.DataSource = null;
		dgvDatos.DataSource = miLista;
		dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		dgvDatos.RowTemplate.Height = 80;

	DataGridViewImageColumn imgCol =
    dgvDatos.Columns["Imagen"] as DataGridViewImageColumn;

	if (imgCol != null)
	{
    	imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
	}
    	txtNombre.Focus();
	}
		//Todo lo de validar, solo es para mostrar los mensajes de error
		
		private bool ValidarCodigo()
		{
			int Codigo;
			if(!int.TryParse(txtCodigo.Text, out Codigo) || txtCodigo.Text == "")
			{
				erpError.SetError(txtCodigo,"El codigo debe ser un valor numerico");
				txtCodigo.Clear();
				txtCodigo.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtCodigo,"");
				return true;
			}
		}
		private bool ValidarRaza()
		{
				if (cmbPuesto.SelectedIndex == -1)
			{
				erpError.SetError(cmbPuesto, "Debe seleccionar un puesto de trabajo");
				return false;
			}
			else
			{
				erpError.SetError(cmbPuesto,"");
				return true;
			}
		}
		private bool ValidarNombre()
		{
			if(string.IsNullOrEmpty(txtNombre.Text))
			{
				erpError.SetError(txtNombre,"Debe ingresar un nombre");
				return false;
				txtNombre.Focus();
			}
			else
			{
				erpError.SetError(txtNombre,"");
				return true;
			}
		}
		private bool ValidarSexo()
		{
			if (cmbSexo.SelectedIndex == -1)
			{
				erpError.SetError(cmbSexo, "Debe seleccionar un sexo");
				return false;
			}
			else
			{
				erpError.SetError(cmbSexo,"");
				return true;
			}
		}
		private bool ValidarFecha()
		{
    		int ac = DateTime.Now.Year;

    		if (dtpFecha.Value.Year == ac)
    		{
        		erpError.SetError(dtpFecha,"Como vas a nacer este año? (·•᷄_•᷅ )");
        		return false;
    		}
    		else
    		{
        	erpError.SetError(dtpFecha,"");
        	return true;
    		}
		}
		private bool ValidarEstado()
		{
    		if (!rbnRegular.Checked && !rbnContrato.Checked)
    		{
        	erpError.SetError(gpbEstado,"Debe seleccionar en contrato o regular");
        	return false;
    		}
    		else
    		{
        	erpError.SetError(gpbEstado,"");
        	return true;
    		}
		}
		private bool ValidarImagen()
		{
    		if (picImagen.Image == null)
    		{
        		erpError.SetError(picImagen, "Debe seleccionar una imagen");
        		return false;
    		}
    		else
    		{
        		erpError.SetError(picImagen, "");
        		return true;
    		}
		}
		//Los botones y menu
		void LimpiarTextoToolStripMenuItemClick(object sender, EventArgs e)
		{
			txtCodigo.Clear();
			txtNombre.Clear();
			cmbPuesto.Text="";
			cmbSexo.Text="";
			dtpFecha.Text="";
			txtNombre.Focus();			
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Esta seguro que desea eliminar a este empleado?","Confirmar salir",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
			{
    			if (dgvDatos.CurrentRow != null)
    			{
       				miLista.RemoveAt(dgvDatos.CurrentRow.Index);
    			}
			}
		}
		void BtnActualizarClick(object sender, EventArgs e)
		{
			OpenFileDialog BuscarImagen = new OpenFileDialog();
			BuscarImagen.Filter = "Archivos de imagen|*.jpg;*.png;*.jpeg";
			BuscarImagen.FileName="";
			BuscarImagen.InitialDirectory="C:\\";
			BuscarImagen.FileName=this.txtRutaArchivo.Text;
			if(BuscarImagen.ShowDialog()==DialogResult.OK)
			{
			this.txtRutaArchivo.Text=BuscarImagen.FileName;
			string Direccion=BuscarImagen.FileName;
			this.picImagen.ImageLocation=Direccion;
			picImagen.SizeMode= PictureBoxSizeMode.StretchImage;
			}
		}
		
		void BtnQuitarClick(object sender, EventArgs e)
		{
			picImagen.Image = null;
    		txtRutaArchivo.Clear();
    		erpError.SetError(picImagen, "");
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtCodigo.Clear();
			txtNombre.Clear();
			cmbPuesto.Text="";
			cmbSexo.Text="";
			dtpFecha.Text="";
			txtNombre.Focus();
			picImagen.Image = null;
    		txtRutaArchivo.Clear();
    		erpError.SetError(picImagen, "");
    		
			foreach (Control control in gpbEstado.Controls)
			{
    			if (control is RadioButton)
    			{
        			((RadioButton)control).Checked = false;
    			}
			}
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Felicidades encontraste un easter egg. ¿Quieres verlo?","Ver easter egg",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
			{
			yuppie h=new yuppie();
			h.Show();
			this.Close();
			}
		}
		
		void CerrarLaApplicacionToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			int Codigo;
			string Nombre, Puesto, Sexo, Estado;
			Codigo = Convert.ToInt32(txtCodigo.Text);
			Nombre = Convert.ToString(txtNombre.Text);
			Puesto = Convert.ToString(cmbPuesto.Text);
			Sexo = Convert.ToString(cmbSexo.Text);
			if(rbnContrato.Checked)
			{
			
				Estado = "Contrato";
			
			}
			else
			{
			
				Estado = "Regular";
			
			}
			AgregarEmpleado(Codigo,Nombre,Puesto,Sexo,Estado);

        }
			public bool AgregarEmpleado(int Codigo, string Nombre, string Puesto, string Sexo, string Estado)
			{
				/// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
            	MySqlConnection cn = new MySqlConnection();
            	cn.ConnectionString = "server=localhost; database=empresa; user=root; pwd=;";
            	cn.Open();
            	/// AGREGAR EL REGISTRO A LA BASE DE DATOS
            	string strSQL = "insert into empleados (Codigo, Nombre, Puesto, Sexo, Estado) "+" values (@Clave, @Nombre, @Puesto, @Sexo, @Estado)";
            	MySqlCommand comando = new MySqlCommand(strSQL, cn);
            	comando.Parameters.AddWithValue("Clave", Codigo);
            	comando.Parameters.AddWithValue("Nombre", Nombre);
            	comando.Parameters.AddWithValue("Puesto", Puesto);
            	comando.Parameters.AddWithValue("Sexo", Sexo);
            	comando.Parameters.AddWithValue("Estado", Estado);
            	comando.ExecuteNonQuery();
            	MessageBox.Show("Empleado fue agregado con exito");
            	/// FINALIZAMOS LA CONEXION CERRAMOS TODO

            	comando.Dispose();
            	cn.Close();
            	cn.Dispose();
            	return true;
		
		
			}
		
		void Button3Click(object sender, EventArgs e)
		{
			
			
		}
		}
	}

