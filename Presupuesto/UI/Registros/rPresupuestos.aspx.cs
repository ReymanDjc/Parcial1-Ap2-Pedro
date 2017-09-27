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

		}

		protected void GuardarButton_Click(object sender, EventArgs e)
		{

			Presupuestos presupuesto = new Presupuestos();
			int id = 0;
			presupuesto = Llenar();
			if (DescripcionTextBox.Text == DescripcionTextBox.Text)
			{
				if (id != presupuesto.PresupuestoId)
				{
					PresupuestoBLL.Modificar(presupuesto);
					//MessageBox.Show("Presupuesto modificado con exito");
				}
				else
				{
					PresupuestoBLL.Guardar(presupuesto);
					//MessageBox.Show("Nuevo presupuesto agregado!");
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

		}

	}
}