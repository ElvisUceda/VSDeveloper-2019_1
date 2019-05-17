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
            var result = false;

            try
            {
                using (var uw = new AppUnitOfWork())
                {
                    /*Editando InvoiceLine*/
                    if (invoiceLine.InvoiceLineId > 0)
                    {
                        uw.InvoiceLineRepository.Update(invoiceLine);
                    }
                    else 
                    {
                        uw.InvoiceLineRepository.Add(invoiceLine);
                    }

                    result = uw.Complete() > 0;
                }

            }
            catch (Exception ex)
            {
                //Agregar el exeption aun log de errores
            }

            return result;
       

        }
    }
}
