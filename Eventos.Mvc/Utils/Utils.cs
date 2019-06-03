using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;
using Eventos.Models;
using Eventos.UnitOfWork;
using Eventos.Mvc.ViewModels;

namespace Eventos.Mvc
{
    public static class Utils
    {
        public static IEnumerable<Comentario> comentarios;
        public static IEnumerable<Usuario> users;

        public static string RolAdministrador = "ADMINISTRADOR";
        public static string RolUsuario = "USUARIO";
        public static string RolInvitado = "";

        public static Dictionary<String, char> TipoEvento = new Dictionary<string, char>
        {
            {"Público", 'P'},
            {"Privado", 'C'},
        };
     
        public static string Rol(this ClaimsIdentity identity)
        {
            return identity.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role).Value;
        }

        public static IEnumerable<EventoViewModel> GetViewModelEventos(IEnumerable<Evento> eventos,IUnitOfWork unit)
        {
            var comentarios = unit.Comentarios.GetList();
            var users = unit.Usuarios.GetList();
            return eventos.Select(m => new EventoViewModel
            {
                evento = m,
                autor = users.Where(u => u.Id == m.IdUsuario).FirstOrDefault(),
                comentarios = comentarios.Where(u => u.IdEvento == m.Id).Select(c => new ComentarioViewModel
                {
                    comentario = c,
                    autor = users.Where(u => u.Id == c.IdUsuario).FirstOrDefault()

                })
            }
            ).ToList();
        }
    }



}