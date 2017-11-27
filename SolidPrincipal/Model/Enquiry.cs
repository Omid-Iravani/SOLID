using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Enquiry: IDiscount
    {
        public Enquiry()
        {
        }

        public  double GetDiscount(double TotalSales)
        {
            return TotalSales-5;
        }

        //public override void Add()
        //{
        //    throw new Exception("Not allowed");
        //}
    }
}
