using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
    public class genericdetailimp<T> : Igenericdetail<T>
    {
        public string getdetail<T1>(T1 obj)
        {
           if(obj is vehicle v)
            {
                return v.details();
            }
            else
            {
                return "not a vehicle";
            }
        }
    }
}
