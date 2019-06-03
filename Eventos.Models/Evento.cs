using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        public string IdUsuario { get; set; }
        [Required(ErrorMessage = "Ingrese el Título.")]
        public string Titulo { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Ingrese la descripción.")]
        public string Descripcion { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Ingrese la ubicación.")]
        public string Ubicacion { get; set; }

        [DataType(DataType.Date)]// Solo permite ingresar fecha, mas no la hora.
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Ingrese la fecha de inicio.")]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.Time)]// Solo permite ingresar la hora.
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Ingrese la hora de inicio.")]
        public TimeSpan HoraInicio { get; set; }

        [DataType(DataType.Time)]// Solo permite ingresar la hora.
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Ingrese la duración.")]
        public TimeSpan Duracion { get; set; }

        public string Tipo { get; set; }


        public string DescTipo()
        {
            return (Tipo == "C") ? "Privado" : "Público";

        }
    }
}
