using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using InvoiceInterface;

namespace Invoice
{
    //Inheriting the Interface.
    public class InvoiceWithoutHeader : Iinvoice
    {
        //Here we call ALL methods defined in the Interface.
        public void print()
        {
            Console.WriteLine("Invoice will print without Headers.");
           
        }
    }
}
