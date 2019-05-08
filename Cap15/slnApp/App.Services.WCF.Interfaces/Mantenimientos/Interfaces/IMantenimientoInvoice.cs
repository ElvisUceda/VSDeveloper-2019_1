﻿using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.WCF.Interfaces
{
    public partial interface IMantenimientosServices
    {
        [OperationContract]
        bool SaveInvoice(Invoice entity);
    }
}
