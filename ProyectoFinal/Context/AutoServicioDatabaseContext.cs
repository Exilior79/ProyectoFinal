using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal.Models;
using System.Collections.Generic;

namespace ProyectoFinal.Context

{
    public class AutoServicioDatabaseContext : DbContext
    {
        public AutoServicioDatabaseContext(DbContextOptions<AutoServicioDatabaseContext> options) : base(options)
        {
        }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Producto> Productos { get; set; }
 
    public DbSet<CarritoDeCompra>? CarritoDeCompra_1 { get; set; }
    }
}
