using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presupuesto.UI.Registros
{
	public partial class rPresupuestos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//Panel1.Visible = false;
		}

		protected void GuardarButton_Click(object sender, EventArgs e)
		{

			Presupuestos presupuesto = new Presupuestos();
			int id = 0;
			presupuesto = Llenar();
			if (DescripcionTextBox.Text == DescripcionTextBox.Text)
			{
				if (!string.IsNullOrEmpty(DescripcionTextBox.Text))
				{
					if (id != presupuesto.PresupuestoId)
					{
						PresupuestoBLL.Modificar(presupuesto);
						//Panel1.Visible = true;
						//MessageBox.Show("Presupuesto modificado con exito");
					}
					else
					{
						PresupuestoBLL.Guardar(presupuesto);
						//Panel1.Visible = true;
						//MessageBox.Show("Nuevo presupuesto agregado!");
					}
				}
				else
				{
					//Label5.Text = "llene los campos vacios";
					//Panel1.Visible = true;
				}

			}
			else
			{
				/*CamposVacioserrorProvider.SetError(ClavetextBox, "Campos no son iguales");
				CamposVacioserrorProvider.SetError(ConfirmartextBox, "Campos no son iguales");
				MessageBox.Show("CAMPOS No Coinciden");*/
			}
			//UsuariosBLL.Guardar(usuario);

		}

		private Presupuestos Llenar()
		{
			Presupuestos presupuesto = new Presupuestos();
			presupuesto.PresupuestoId = Utilidades.TOINT(PresupuestoIdTextBox.Text);
			presupuesto.Descripcion = DescripcionTextBox.Text;
			presupuesto.Fecha = Convert.ToDateTime(FechaTextBox.Text);
			presupuesto.Monto = Utilidades.TOINT(MontoTextBox.Text);
			return presupuesto;
		}

		private void Limpiar()
		{
			PresupuestoIdTextBox.Text = "";
			DescripcionTextBox.Text = "";
			FechaTextBox.Text = "";
			MontoTextBox.Text = "";
			//Panel1.Visible = false;
		}

		protected void NuevoButton_Click(object sender, EventArgs e)
		{
			Limpiar();
		}

		protected void EliminarButton_Click(object sender, EventArgs e)
		{

			int id = Utilidades.TOINT(PresupuestoIdTextBox.Text);

			if (PresupuestoBLL.Eliminar(PresupuestoBLL.Buscar(p => p.PresupuestoId == id)))
			{
				Limpiar();
				//MessageBox.Show("El Presupuesto se elimino con exito.");
			}
			else
			{
				//MessageBox.Show("El Presupuesto no se pudo eliminar.");
			}
		}

		protected void BuscarButton_Click(object sender, EventArgs e)
		{
			int id = Utilidades.TOINT(PresupuestoIdTextBox.Text);
			var presupuesto = new Presupuestos();

			presupuesto = PresupuestoBLL.Buscar(p => p.PresupuestoId == id);

			if (presupuesto != null)
			{
				DescripcionTextBox.Text = presupuesto.Descripcion;
				MontoTextBox.Text = presupuesto.Monto.ToString();
				FechaTextBox.Text = presupuesto.Fecha.ToString();
			}
			else
			{
				//MessageBox.Show("No existe.");
				Limpiar();
			}
		}
	}
}