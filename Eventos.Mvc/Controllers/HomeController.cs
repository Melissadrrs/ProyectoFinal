using Eventos.Mvc.ViewModels;
using Eventos.Repositories.Dapper.Eventos;
using Eventos.UnitOfWork;
using log4net;
using Microsoft.Ajax.Utilities;
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
    public class HomeController:BaseController 
    {
        public HomeController(ILog log, IUnitOfWork unit) : base(log, unit) { }

        public ActionResult Index()
        {
            #region Permisos
                ViewBag.UserRol = (User.Identity.IsAuthenticated) ? Utils.Rol(((ClaimsIdentity)User.Identity)) : "";
                ViewBag.UserId = User.Identity.GetUserId();
            #endregion Permisos

            var eventos = _unit.Eventos.GetList().Where(q => q.Tipo == "P");
            var viewEvento = Utils.GetViewModelEventos(eventos,_unit);
   
            EventosViewModel obj = new EventosViewModel();
            obj.EventPasados = viewEvento.Where(q => q.evento.FechaInicio < DateTime.Today);
            obj.EventProximos = viewEvento.Where(q => q.evento.FechaInicio >= DateTime.Today);
            return View(obj);
        }


    }
}