using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public class GoldCustomer:Cusomer
    {
        public GoldCustomer(ILogger i):base(i)
        {

        }
        public override double GetDiscount(double TotalSales)
        {
            return base.GetDiscount(TotalSales)-100;
        }
    }
}
