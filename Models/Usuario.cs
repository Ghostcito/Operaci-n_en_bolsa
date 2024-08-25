using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operación_en_bolsa.Models
{
    public class Usuario
    {
        public string? Nombre {get;set;}
        public string? Apellido {get;set;}
        public string? Email {get;set;}
        public DateOnly? Fecha {get;set;}
        public string? Instrumento {get;set;}
        public decimal? Monto{get;set;}

        public string getNombre(){
            return this.Nombre;
        }
    }
}