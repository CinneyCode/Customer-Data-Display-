using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // make an object using the CustomerDatabase class
            // Instantiation
            CustomerDatabase cd = new CustomerDatabase();
            // call the read customer data method
            List<Customer> myCust = cd.ReadCustomerData();
            //
            foreach (Customer c in myCust)
            {
                Console.Write($"{c.ToString()}");
            }

            Console.ReadKey();
        }
    }
}
