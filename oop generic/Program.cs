using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           car c= new car(6,6,"BMW",1500,2021,5,vehicletype.personal);
           c. addInteriordesign  ("auto drive", "miusic sestem");
           vehicledetailimp<car>gd= new vehicledetailimp<car>();
            Console.WriteLine(gd.getdetail<car>(c));
            Console.WriteLine(c.getInteriordesign());
            Console.WriteLine();

            motorcycle m1 = new motorcycle("R15", 50, 2017, 5, vehicletype.personal, "air cool", "disk", "drum", "hero", 14, 15, 50);
            m1.addExteriordesign("vip horn");
            genericdetailimp<motorcycle> md = new genericdetailimp<motorcycle>();
            Console.WriteLine(md.getdetail<motorcycle>(m1));
            Console.WriteLine(m1.getExteriordesign());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
