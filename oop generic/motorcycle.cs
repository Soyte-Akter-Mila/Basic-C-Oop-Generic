using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
    public sealed class motorcycle : twowheeler
    {
        public motorcycle()
        {
        }

        public motorcycle(string model, int cc, int yearmake, int noofgear, vehicletype vehicletype, string stmethode, string fbreak, string rbreak, string cooling, int maxpBPH, int maxtNM, int mileage) : base(model, cc, yearmake, noofgear, vehicletype, stmethode, fbreak, rbreak, cooling, maxpBPH, maxtNM, mileage)
        {
        }
    }
}
