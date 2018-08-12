using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InstitutoWebApp.Models
{
    public class Estudiantes
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        public int Edad { get; set; }

        [StringLength(200)]
        [Required]
        public string Direccion { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        [StringLength(11)]
        public string Cedula { get; set; }

        public int IdCarreras { get; set; }

        [ForeignKey("IdCarreras")]
        public Carreras Carreras { get; set; }
    }
}
