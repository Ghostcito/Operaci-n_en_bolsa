using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Operación_en_bolsa.Models
{
    public class Usuario
    {
        public string? Nombre {get;set;}
        public string? Apellido {get;set;}
        public string? Email {get;set;}
        [DataType(DataType.Date)]
        public DateTime? Fecha {get;set;}
        public List<string> Instrumentos {get;set;}=new List<string>{"S&P", "Down Jones","Bonos US"};
        public List<string> InstrumentosSeleccionados {get;set;}=new List<string>();
        public decimal Monto{get;set;}
        
        public decimal CalcularInversion(){
            return Monto/(decimal)InstrumentosSeleccionados.Count()*1.0m; 
        }
        public decimal CalcularIGV(){
            return CalcularInversion()*0.18m;
        }
        public decimal CalcularMonto(){
            return CalcularInversion()+CalcularIGV();
        }
        public decimal CalcularComision(){
            decimal comision;
            if(this.Monto>300)comision=1;
            else comision=3;
            return comision;
        }
         public double CalcularMontoTotal(){
           return (double)(CalcularComision()+CalcularMonto()*(decimal)InstrumentosSeleccionados.Count());
        }
        
    }
}