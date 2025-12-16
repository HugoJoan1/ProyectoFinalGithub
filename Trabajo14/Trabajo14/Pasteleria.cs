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
		
		void BtnGuardarSQLClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnImprimirClick(object sender, EventArgs e)
		{
			if (DGVProductos.Rows.Count == 0)
    		{
        		MessageBox.Show("No hay productos para imprimir");
        		return;}
			
		    MessageBox.Show("Ticket impreso correctamente");
		}
		
		void BtnBorrarSQLClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
			Main mn = new Main();
			mn.Show();
		}
		void CalcularDescuento(double subtotal, int totalProductos)
		{
		    double descuento = 0;
    		if (totalProductos > 3 && subtotal >= 200)
        	descuento = subtotal * 0.15;
    		else if (subtotal >= 200)
        	descuento = subtotal * 0.10;
    		else if (totalProductos > 3)
        	descuento = subtotal * 0.07;
    		txtDescuento.Text = descuento.ToString("0.00");
    		txtImporteNeto.Text = (subtotal - descuento).ToString("0.00");
		}
		void CalcularSubtotal()
		{
		    double subtotal = 0;
    		int totalProductos = 0;
    		foreach (DataGridViewRow fila in DGVProductos.Rows)
    		{
        		subtotal += Convert.ToDouble(fila.Cells[3].Value);
        		totalProductos += Convert.ToInt32(fila.Cells[2].Value);
    		}
    		txtSubtotal.Text = subtotal.ToString("0.00");
		    CalcularDescuento(subtotal, totalProductos);
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if (cmbProducto.SelectedIndex == -1 || txtCantidad.Text == "")
    			{
    			    MessageBox.Show("Selecciona un producto y cantidad");
    			    return;
    			}

    		DGVProductos.Rows.Add(
    	    cmbProducto.Text,
    	    txtPrecio.Text,
    	    txtCantidad.Text,
    	    txtTotal.Text);
    		CalcularSubtotal();
		    LimpiarProducto();
		}
		void LimpiarProducto()
		{
		    cmbProducto.SelectedIndex = -1;
    		txtPrecio.Clear();
    		txtCantidad.Clear();
		    txtTotal.Clear();
		}
		
		void BtnBorrarProductoClick(object sender, EventArgs e)
		{
			if (DGVProductos.SelectedRows.Count > 0)
    			{
        		DGVProductos.Rows.RemoveAt(DGVProductos.SelectedRows[0].Index);
        		CalcularSubtotal();
    			}
    		else
   				{
    	    	MessageBox.Show("Selecciona un producto para borrar");
    			}
		}
		
		void CmbProductoSelectedIndexChanged(object sender, EventArgs e)
		{
			double precio = 0;

			if (cmbProducto.Text == "Pastel de Chocolate") precio = 200;
			else if (cmbProducto.Text == "Cheesecake") precio = 30;
			else if (cmbProducto.Text == "Cupcake") precio = 150;
			else if (cmbProducto.Text == "Pay de limón") precio = 180;
			else if (cmbProducto.Text == "Malteadas") precio = 20;
			else if (cmbProducto.Text == "Empanada") precio = 25;
			else if (cmbProducto.Text == "Croissant") precio = 20;
			else if (cmbProducto.Text == "Quiche") precio = 40;
			else if (cmbProducto.Text == "Pan de ajo") precio = 50;
			else if (cmbProducto.Text == "Crepa Salada") precio = 15;

			txtPrecio.Text = precio.ToString("0.00");
			txtCantidad.Clear();
			txtTotal.Clear();
		}
		
		void TxtPrecioTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void RdbDulceCheckedChanged(object sender, EventArgs e)
		{
			if (rdbDulce.Checked)
			{
				rdbDulce.BackColor = Color.Green;
				rdbSalado.BackColor = Color.Red;

				cmbProducto.Items.Clear();
				cmbProducto.Items.Add("Pastel de Chocolate");
				cmbProducto.Items.Add("Cheesecake");
				cmbProducto.Items.Add("Cupcake");
				cmbProducto.Items.Add("Pay de limón");
				cmbProducto.Items.Add("Malteadas");
				cmbProducto.SelectedIndex = -1;
			}
		}
		
		void RdbSaladoCheckedChanged(object sender, EventArgs e)
		{
			if (rdbSalado.Checked)
			{
				rdbSalado.BackColor = Color.Green;
				rdbDulce.BackColor = Color.Red;

				cmbProducto.Items.Clear();
				cmbProducto.Items.Add("Empanada");
				cmbProducto.Items.Add("Croissant");
				cmbProducto.Items.Add("Quiche");
				cmbProducto.Items.Add("Pan de ajo");
				cmbProducto.Items.Add("Crepa Salada");
				cmbProducto.SelectedIndex = -1;
			}
		}
		
		void TxtCantidadTextChanged(object sender, EventArgs e)
		{
			double precio;
			int cantidad;

			if (double.TryParse(txtPrecio.Text, out precio) &&
				int.TryParse(txtCantidad.Text, out cantidad))
			{
				txtTotal.Text = (precio * cantidad).ToString("0.00");
			}
			else
			{
				txtTotal.Clear();
			}
		}
		
		void TxtTotalTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
