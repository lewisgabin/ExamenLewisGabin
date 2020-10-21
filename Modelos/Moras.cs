
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamosDetalle.Modelos

{
    public class Moras
    {
        [Key]
        public int MoraId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar la fecha")]
        [DataType(DataType.Date)]
       
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Debe insertar el total de la mora")]
        public decimal Total { get; set; }

        [ForeignKey("MoraId")]
        public virtual List<DetalleMora> DetalleMora { get; set; }

        public Moras()
        {
            MoraId = 0;
            Fecha = DateTime.Now;
            Total = 0;
            DetalleMora = new List<DetalleMora>();
        } 
    }
}