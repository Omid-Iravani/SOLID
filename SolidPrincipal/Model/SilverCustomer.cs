using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SilverCustomer:Cusomer
    {

        public SilverCustomer(ILogger i):base(i)
        {

        }
        public override double GetDiscount(double TotalSales)
        {
            return base.GetDiscount(TotalSales)-50;
        }

    }
}
