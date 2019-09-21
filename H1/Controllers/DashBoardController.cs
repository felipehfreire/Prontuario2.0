using H1.ClaimsFilter;
using H1.Services.Service.AgendaService;
using H1.Services.ViewModel.Agenda;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using H1.Services.ViewModel.Select2;

namespace H1.Controllers
{
    [Authorize]
    //[ClaimsAuthorize("DashBoard", "true")]
    public class DashBoardController : ControllerBase
    {
        public DashBoardController()
        {
            
        }

        public ActionResult Index()
        {
            return View();
        }


    }
}