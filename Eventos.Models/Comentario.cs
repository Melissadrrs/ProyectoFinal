using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class Comentario
    {

        public int Id { get; set; }
        public int IdEvento { get; set; }
        public string IdUsuario { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Ingrese comentario para el evento.")]
        public string Contenido { get; set; }

        public DateTime Fecha { get; set; }

    }
}
