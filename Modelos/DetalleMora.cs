using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamosDetalle.Modelos
{
    public class DetalleMora
    {
         [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el id de la mora")]
        public int MoraId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar el id del prestamo")]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "Debe ingresar el valor de la mora")]
        public decimal Valor { get; set; }

        public  DetalleMora()
        {
            Id = 0;
            MoraId = 0;
            PrestamoId = 0;
            Valor = 0;
        }
    }
}