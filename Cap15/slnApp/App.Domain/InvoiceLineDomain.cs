using App.DataAccess.Repository;
using App.Domain.Interfaces;
using App.Entities.Base;
using App.Entities.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
    public class InvoiceLineDomain : IInvoiceLineDomain
    {
        public bool SaveInvoiceLine(InvoiceLine invoiceLine)
        {
           

            return true;

        }
    }
}
