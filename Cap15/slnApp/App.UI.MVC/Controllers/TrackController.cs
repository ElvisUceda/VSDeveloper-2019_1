using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Entities.Queries;
using App.UI.MVC.MantenimientosServices;

namespace App.UI.MVC.Controllers
{
   
    public class TrackController : Controller

    {
        ReportesServicesClient reportesServicesClient = null;
        MantenimientosServicesClient mantenimientosServicesClient = null;
        

        public TrackController()
        {
            reporteServicesClient = 
                new ReportesServices.ReporteServicesClient();
        }

        // GET: Track
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string filtroByNombre)
        {
            filtroByNombre= string.IsNullOrWhiteSpace(filtroByNombre)? "%":
        }



        public ActionResult VenderTrack()
        {
            var customers = MantenimientosServicesClient.GetCustomers(" ");
            ViewBag.customers = customers;

            var tracks = reportesServicesClient.GetTrackAll(" ");
            ViewBag.tracks = tracks;

            return View();
        }
    }
}