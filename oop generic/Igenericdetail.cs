using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
    public interface Igenericdetail<T>
    {
        string getdetail<T>(T obj);
    }
}
