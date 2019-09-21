using H1.ClaimsFilter;
using H1.Services.Service.AgendaService;
using H1.Services.ViewModel.Agenda;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using H1.Services.ViewModel.Select2;
using H1.Services.Service.Paciente;

namespace H1.Controllers
{
    [Authorize]
    //[ClaimsAuthorize("Paciente", "true")]
    public class PacienteController : ControllerBase
    {
        private PacienteService _pacienteService;
        public PacienteController(PacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult PesquisarPacienteS2(string q)
        {
            DataS2ViewModel data = new DataS2ViewModel();
            try
            {
                data.items = _pacienteService.PesquisarPacienteS2(q);

                data.responseText = (int)HttpStatusCode.OK;
                Response.StatusCode = (int)HttpStatusCode.OK;

            }
            catch (Exception ex)
            {

                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                data.responseText = (int)HttpStatusCode.BadRequest;
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
            
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}