using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
    public class twowheeler:vehicle,IExteriordesign
    {
        private List<string> Exdesign = new List<string>();
        public twowheeler()
        {
        }

        public twowheeler(string model, int cc, int yearmake, int noofgear, vehicletype vehicletype, string stmethode, string fbreak, string rbreak, string cooling, int maxpBPH, int maxtNM, int mileage) : base(model, cc, yearmake, noofgear, vehicletype)
        {
        

      
            this.stmethode = stmethode;
            this.fbreak = fbreak;
            this.rbreak = rbreak;
            this.cooling = cooling;
            this.maxpBPH = maxpBPH;
            this.maxtNM = maxtNM;
            this.mileage = mileage;
        }

        public string stmethode { get; set; }
        public string fbreak { get; set; }
        public string rbreak { get; set; }
        public string cooling { get; set; }
        public int maxpBPH { get; set; }
        public int maxtNM{ get; set; }
        public int mileage { get; set; }
        

        public void addExteriordesign(params string[] design)
        {
            this.Exdesign.AddRange(design);
        }

        public override string details()
        {
            return $"{model},  {cc},  {yearmake}, {noofgear},{vehicletype}, {stmethode}, {fbreak}, {rbreak},  {cooling},   {mileage} ";
        }

        public string getExteriordesign()
        {
            return string.Join(",", Exdesign);
        }
    }
}
