﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PresupuestoDb : DbContext
    {

		public DbSet<Presupuestos> Presupuestos { get; set; }

		public PresupuestoDb() : base("ConStr")
		{
				
		}
	}
}
