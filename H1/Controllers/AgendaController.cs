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
    [ClaimsAuthorize("MedicSchedule", "true")]
    public class AgendaController : ControllerBase
    {
        private AgendaService _agendaService;
        public AgendaController(AgendaService agendaService)
        {
            _agendaService = agendaService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetListaAtendimentos(string codigoPaciente)
        {
            var agenda = new List<AgendaMedicaViewModel>();
            try
            {
                agenda = _agendaService.GetAgendaMedica(codigoPaciente, CurrentUserID);
                Response.StatusCode = (int)HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }

            return Json(agenda, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult PesquisarPacienteS2(string q)
        {
                DataS2ViewModel data = new DataS2ViewModel();
            try
            {
                data.items = _agendaService.PesquisarPacienteS2(q);
                data.responseText = (int)HttpStatusCode.OK;

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