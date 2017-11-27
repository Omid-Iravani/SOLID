using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cusomer> customer = new List<Cusomer>();

            customer.Add(new GoldCustomer(new EmailLogger()));
            customer.Add(new SilverCustomer(new EverViewerLogger()));
            //customer.Add(new Enquiry());

            foreach (var item in customer)
            {
                item.Add();
            }

        }
    }
}
