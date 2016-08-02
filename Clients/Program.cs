using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoiceInterface;
using FactoryInvoice;

namespace Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            int intInvoiceType = 0;

            //Creating an instance of Iinvoice Class.
            Iinvoice objInvoice;

            Console.WriteLine("Enter the Invoice Type");

            //taking input from the user  which will decide to create dynamic Object Creation.
            intInvoiceType = Convert.ToInt32(Console.ReadLine());
            objInvoice = MyFactoryInvoice.getInvoice(intInvoiceType);
            objInvoice.print();
            Console.ReadLine();
        }
    }
}
