using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Service.WCFAppTest
{
    [TestClass]
    public class InvoiceServiceTest
    {
        [TestMethod]
        public void SaveInvoice()
        {
            var invoiceTest = new Invoice();
            invoiceTest.CustomerId = 1;
            invoiceTest.InvoiceDate = DateTime.Now;
            invoiceTest.InvoiceLine = new List<InvoiceLine>();
            invoiceTest.InvoiceLine.Add(
                new InvoiceLine()
                {
                    Quantity = 12,
                    TrackId = 1,
                    UnitPrice = 10
                }
                );

        }
    }
}
