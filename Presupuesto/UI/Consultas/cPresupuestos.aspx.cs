using BLL;
using Entidades;
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
		public static List<Presupuestos> Lista { get; set; }


		protected void Page_Load(object sender, EventArgs e)
		{
			PresupuestoGridView.DataBind();
			//FechaunoTextBox.Enabled = false;
			//FechadosTextBox.Enabled = false;
		}

		protected void FiltrarButton_Click(object sender, EventArgs e)
		{
			PresupuestoGridView.DataSource = PresupuestoBLL.GetListAll();

			DateTime desde = DateTime.Now;
			DateTime hasta = DateTime.Now;

			

			if (PresupuestoDropDownList.SelectedIndex == 0)
			{
				Lista = PresupuestoBLL.GetListAll();
				PresupuestoGridView.DataSource = Lista;
				PresupuestoGridView.DataBind();
			}
			else
			if (PresupuestoDropDownList.SelectedIndex == 1)
			{
				//FechaunoTextBox.Enabled = true;
				//FechadosTextBox.Enabled = true;


				Lista = PresupuestoBLL.GetList(p => p.Fecha >= desde.Date && p.Fecha <= hasta.Date);
				
				PresupuestoGridView.DataSource = Lista;
				PresupuestoGridView.DataBind();
			}
			else
			if (PresupuestoDropDownList.SelectedIndex == 2)
			{
				Lista = PresupuestoBLL.GetList(p => p.PresupuestoId == Convert.ToInt32(FiltrarTextBox));

				PresupuestoGridView.DataSource = PresupuestoBLL.GetList(p => p.Descripcion == FiltrarTextBox.Text);
				PresupuestoGridView.DataBind();
			}
			else
			if (PresupuestoDropDownList.SelectedIndex == 3)
			{
				int id = Utilidades.TOINT(FiltrarTextBox.Text);
				Lista = PresupuestoBLL.GetList(p => p.PresupuestoId == id);
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