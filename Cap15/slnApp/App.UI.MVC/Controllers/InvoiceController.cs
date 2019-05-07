using App.Entities.Base;
using App.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.UI.MVC.Controllers
{
    [Authorize]
    public class InvoiceController : Controller
    {
        MantenimientosServices.MantenimientosServicesClient wcfClient = null;

        public InvoiceController()
        {
            wcfClient = new MantenimientosServices.MantenimientosServicesClient();

        }

      
    }
}