using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
    public class fourwheeler:vehicle,IInteriordesign
    {private List<string>Indesign=new List<string>();
        public fourwheeler()
        {
        }

       

        public fourwheeler(int noofdoor, int noofseat,string model, int cc, int yearmake, int noofgear, vehicletype vehicletype) : base(model, cc, yearmake, noofgear, vehicletype)
        {
            this.noofdoor = noofdoor;
            this.noofseat = noofseat;
        }

        public int noofdoor { get; set; }
        public int noofseat{ get; set; }

        public void addInteriordesign(params string[] design)
        {
            this.Indesign.AddRange(design);
        }

        public override string details()
        {
            return $" {noofdoor},  {noofseat},{model},  {cc},  {yearmake}, {noofgear},{vehicletype}";
        }

        public string getInteriordesign()
        {
            return string.Join(",", Indesign);
        }
    }
}
