using Backend_SS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SS
{
    // AplicationDbContext extends DbContext // Herencia
    public class AplicationDbContext: DbContext
    {
        // Se mapea nuestro MODELO con la BASE DE DATOS
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
