using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

   
    public class Cusomer:IDiscount,IDatabase
    {

        public Cusomer(ILogger i)
        {

            obj = i;

        }

        //So SRP says that a class should have only one responsibility and not multiple.
        private ILogger obj;

        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                obj.Handle(ex.Message.ToString());
            }
        }

        public virtual double GetDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }


}
