using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoiceInterface;
using Invoice;

namespace FactoryInvoice
{
    public class MyFactoryInvoice
    {

       //Program to an Interface NOT an Implementation.(follows OCP). 
       static public Iinvoice getInvoice(int intInvoiceType)
        {
            Iinvoice objinv;

            if (intInvoiceType == 1)
            {
                objinv = new InvoiceWithHeader();
            }
            else if (intInvoiceType == 2)
            {
                objinv = new InvoiceWithoutHeader(); 
            }
            else {
                return null;            
            }
            return objinv;
        }
    }
}
