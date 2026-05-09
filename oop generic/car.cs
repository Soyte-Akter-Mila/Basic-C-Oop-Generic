using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
    public sealed class car : fourwheeler
    {
        public car()
        {
        }

        public car(int noofdoor, int noofseat, string model, int cc, int yearmake, int noofgear, vehicletype vehicletype) : base(noofdoor, noofseat, model, cc, yearmake, noofgear, vehicletype)
        {
        }
    }
}
