using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamosDetalle.Modelos

{
    public class Personas
    {
          [Key]
        public int PersonaId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Debe tener mas de dos letras")]
        public string Nombres { get; set; }

        [Required]
        [Phone]
        [MaxLength(10, ErrorMessage = "Telefono no es correcto")]
        public string Telefono { get; set; }

        [Required]
        [MinLength(11, ErrorMessage = "Cedula demasiado corta")]
        [MaxLength(11, ErrorMessage = "Ha excedido la cantidad de numeros que contiene una cedula")]
        public string Cedula { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public decimal Balance { get; set; }

        public Prestamos Prestamos { get; set; }

    }
}