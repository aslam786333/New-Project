using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoiceInterface;

namespace Invoice
{
    // Inheriting the Interface.
    public class InvoiceWithHeader: Iinvoice 
    {
        //Here we call ALL methods defined in the Interface.
        public void print()
        {
            Console.WriteLine("Invoice will print with Headers");
        }
    }
}
