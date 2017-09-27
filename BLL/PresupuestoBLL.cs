using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PresupuestoBLL
    {
		public static bool Guardar(Presupuestos presupuesto)
		{
			using (var conec = new Repository<Presupuestos>())
			{
				try
				{
					return conec.Guardar(presupuesto);
				}
				catch (Exception)
				{

					throw;
				}
			}
			return false;
		}



		public static bool Eliminar(Presupuestos presupuesto)
		{
			using (var conec = new Repository<Presupuestos>())
			{
				try
				{
					return conec.Eliminar(presupuesto);
				}
				catch (Exception)
				{

					throw;
				}
			}
			return false;
		}

		public static bool Modificar(Presupuestos presupuesto)
		{
			using (var conec = new Repository<Presupuestos>())
			{
				try
				{
					return conec.Modificar(presupuesto);
				}
				catch (Exception)
				{

					throw;
				}
			}
			return false;
		}


		public static Presupuestos Buscar(Expression<Func<Presupuestos, bool>> criterio)
		{
			using (var conec = new Repository<Presupuestos>())
			{
				try
				{
					return conec.Buscar(criterio);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public static Presupuestos BuscarOtro(int id)
		{
			using (var context = new Repository<Presupuestos>())
			{
				try
				{
					return context.BuscarOtro(id);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}


		public static List<Presupuestos> GetList(Expression<Func<Presupuestos, bool>> criterio)
		{
			using (var conec = new Repository<Presupuestos>())
			{
				try
				{
					return conec.GetList(criterio);
				}
				catch (Exception)
				{
					throw;
				}
			}
		}

		public static List<Presupuestos> GetListAll()
		{
			using (var conec = new Repository<Presupuestos>())
			{
				try
				{
					return conec.GetListAll();
				}
				catch (Exception)
				{

					throw;
				}
			}
		}






	}
}
