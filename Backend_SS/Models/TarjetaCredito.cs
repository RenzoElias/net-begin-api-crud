using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Migracion Code-First // Osea que sea crea desde el Model
// Si fuera desde la BD, luego se pondria el model pero de acuerdo a la BD
namespace Backend_SS.Models
{
    public class TarjetaCredito
    {
        public int Id { get; set; } // Al poner id, la aplicacion ya lo toma como PK
        [Required]
        public string Titular { get; set; }
        [Required]
        public string NumeroTarjeta { get; set; }
        [Required]
        public string FechaExpiracion { get; set; }
        [Required]
        public string CVV { get; set; }

    }
}
