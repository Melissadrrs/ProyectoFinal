using Eventos.Models;
using Eventos.Mvc.ViewModels;
using Eventos.Repositories.Dapper.Eventos;
using Eventos.UnitOfWork;
using log4net;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Eventos.Mvc.Controllers
{
    public class EventosController : BaseController
    {
        public EventosController(ILog log, IUnitOfWork unit) : base(log, unit) { }

        public ActionResult Index()
        {
            #region Permisos
                ViewBag.UserRol = (User.Identity.IsAuthenticated) ? Utils.Rol(((ClaimsIdentity)User.Identity)) : "";
                ViewBag.UserId = User.Identity.GetUserId();
            #endregion Permisos

            var filterUser = (ViewBag.UserRol == Utils.RolUsuario) ? ViewBag.UserId : "0";
            var eventos = _unit.Eventos.GetList().Where(q => (q.IdUsuario == filterUser || filterUser=="0"));

            var viewEvento = Utils.GetViewModelEventos(eventos, _unit);

            return View(viewEvento);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Evento evento)
        {
            if (ModelState.IsValid)
            {
                evento.IdUsuario = User.Identity.GetUserId();
                int result = _unit.Eventos.Insert(evento);
                return RedirectToAction("Index");
            }
            return View(evento);

        }

        public ActionResult Delete(int Id)
        {
            var eventos = _unit.Eventos.GetById(Id);
            _unit.Eventos.Delete(eventos);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            var eventos = _unit.Eventos.GetById(Id);
            return View(eventos);
        }

        [HttpPost]
        public ActionResult Edit(Evento evento)
        {
            if (ModelState.IsValid)
            {
               
                bool result = _unit.Eventos.Update(evento);
                return RedirectToAction("Index");
            }
            return View(evento);
        }

        public ActionResult Details(int Id)
        {
                #region Permisos
                ViewBag.UserRol = (User.Identity.IsAuthenticated) ? Utils.Rol(((ClaimsIdentity)User.Identity)) : "";
                ViewBag.UserId = User.Identity.GetUserId();
                #endregion Permisos

            ViewBag.IdEvento = Id;
            var eventos=_unit.Eventos.GetById(Id);
            var obj=Utils.GetViewModelEventos(new List<Evento>() {eventos}.AsEnumerable(), _unit).FirstOrDefault();
            return View(obj);
        }
    }
}