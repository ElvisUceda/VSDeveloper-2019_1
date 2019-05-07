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
    public class InvoiceDomain : IInvoiceDomain
    {
        public bool SaveInvoice(Invoice invoice)
        {
            var result = false;

            try
            {
                using (var uw = new AppUnitOfWork())
                {
                    /*Editando */
                    if (invoice.InvoiceId > 0)
                    {
                        uw.InvoiceRepository.Update(invoice);
                    }
                    else //Cuando es nuevo factura
                    {
                        uw.InvoiceRepository.Add(invoice);
                    }

                    result = uw.Complete() > 0;
                }

            }
            catch (Exception ex)
            {
                //Agregar el exeption aun log de errores
            }

            return true;
        }
    }
}

/*
 En la prueba unitaria

var invoiceTest = new Invoice();
invoiceTest.CustomerId = 1;
invoiceTest.InvoiceDate = DateTime.Now;
invoiceTest.InvoiceLine = new List<InvoiceLine>();
invoiceTest.InvoiceLine.Add(
    new InvoiceLine()
    {
        Quantity=12,
        TrackId = 1,
        UnitPrice = 10
    }
    );

*/


