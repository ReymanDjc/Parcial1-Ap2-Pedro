using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presupuesto.UI.Consultas
{
	public partial class cPresupuestos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			PresupuestoGridView.DataBind();
		}

		protected void FiltrarButton_Click(object sender, EventArgs e)
		{
			PresupuestoGridView.DataSource = PresupuestoBLL.GetListAll();

			if (PresupuestoDropDownList.SelectedIndex == 0)
			{
				PresupuestoGridView.DataSource = PresupuestoBLL.GetListAll();
				PresupuestoGridView.DataBind();
			}
			else
			if (PresupuestoDropDownList.SelectedIndex == 2)
			{
				PresupuestoGridView.DataSource = PresupuestoBLL.GetList(p => p.Descripcion == FiltrarTextBox.Text);
				PresupuestoGridView.DataBind();
			}
			else
			if (PresupuestoDropDownList.SelectedIndex == 3)
			{
				int id = Utilidades.TOINT(FiltrarTextBox.Text);
				PresupuestoGridView.DataSource = PresupuestoBLL.GetList(p => p.PresupuestoId == id);
				PresupuestoGridView.DataBind();
			}

		}

		protected void ImprimirButton_Click(object sender, EventArgs e)
		{
			Response.Redirect("../Reportes/rPresupuestos.aspx");
		}
	}
}