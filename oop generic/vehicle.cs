using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
 public abstract class vehicle
    {
        protected vehicle()
        {
        }

        protected vehicle(string model, int cc, int yearmake, int noofgear, vehicletype vehicletype)
        {
            this.model = model;
            this.cc = cc;
            this.yearmake = yearmake;
            this.noofgear = noofgear;
            this.vehicletype = vehicletype;
        }

        public string model { get; set; }
        public int cc { get; set; }
        public int yearmake { get; set; }
        public int noofgear{ get; set; }
        public vehicletype vehicletype{ get; set; }
        public abstract string details();
    }
}
