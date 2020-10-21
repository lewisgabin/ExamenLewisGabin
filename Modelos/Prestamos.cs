  
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamosDetalle.Modelos
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Debe ingresar el id de la persona")]
        public int PersonaId { get; set; }
        public Personas Personas { get; set; }

        [Required]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "El campo monto no puede estar vacio.")]
        public decimal Monto { get; set; }

        [Required]
        public decimal Balance { get; set; }

         public Prestamos()
        {
            PrestamoId = 0;
            Fecha = DateTime.Now;
            PersonaId = 0;
            Concepto = string.Empty;
            Monto = 0;
            Balance = 0;
        }
    }

    
}