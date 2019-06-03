using Eventos.Models;
using Eventos.UnitOfWork;
using log4net;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eventos.Mvc.Controllers
{
    public class ComentariosController : BaseController
    {
        public ComentariosController(ILog log, IUnitOfWork unit) : base(log, unit) { }

        public ActionResult Create(int Id, string Url)
        {
            ViewBag.IdEvento = Id;
            ViewBag.Url = Url;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Comentario comentario, int Id, string Url)
        {
           if (ModelState.IsValid) { 
                comentario.IdEvento = Id;
                comentario.IdUsuario = User.Identity.GetUserId();
                comentario.Fecha = DateTime.Today;
                int result = _unit.Comentarios.Insert(comentario);
                return Redirect(Url);
            }
            ViewBag.IdEvento = Id;
            ViewBag.Url = Url;
            return View(comentario);

      
        }

    
        public ActionResult Delete(int Id, string Url)
        {
            var comentario = _unit.Comentarios.GetById(Id);
            _unit.Comentarios.Delete(comentario);
            return Redirect(Url);
        }
    }
}