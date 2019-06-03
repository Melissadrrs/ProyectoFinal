using Eventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventos.Mvc.ViewModels
{
    public class ComentarioViewModel
    {
        public Comentario comentario { get; set; }
        public Usuario autor { get; set; }
    }
    public class EventoViewModel
    {
        public Evento evento { get; set; }
        public Usuario autor { get; set; }
        public IEnumerable<ComentarioViewModel> comentarios { get; set; }
    }
    public class EventosViewModel
    {
        public IEnumerable<EventoViewModel> EventProximos { get; set; }
        public IEnumerable<EventoViewModel> EventPasados { get; set; }
    }
}