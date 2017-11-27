using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public interface IDatabaseV1:IDatabase
    {
        void Read();
    }
}
