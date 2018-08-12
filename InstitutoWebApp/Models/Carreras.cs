using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstitutoWebApp.Models
{
    public class Carreras
    {
        public int Id { get; set; }
        [StringLength(50, ErrorMessage ="Este campo debe ser menor a 50 caracteres")]
        [Display(Name ="Nombre de Carrera")]
        public string NombreCarrera { get; set; }

        public List<Estudiantes> Estudiantes { get; set; }
    }
}
