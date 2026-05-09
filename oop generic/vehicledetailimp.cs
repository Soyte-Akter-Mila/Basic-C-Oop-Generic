using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
    internal class vehicledetailimp<T> : Ivehicledetail<T>
    {
        public string getdetail<T1>(T1 obj) where T1 : vehicle
        {
            return obj.details();
        }
    }
}
