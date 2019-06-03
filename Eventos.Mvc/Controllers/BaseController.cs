using Eventos.UnitOfWork;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Eventos.Mvc.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IUnitOfWork _unit;
        protected readonly ILog _log;
        // GET: Base
        public BaseController(ILog log, IUnitOfWork unit)
        {
            _log = log;
            _unit = unit;
        }


    }
}