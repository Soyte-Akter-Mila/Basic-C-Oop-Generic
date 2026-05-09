using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //if--else
            if (DateTime.Now.Hour > 12)
            {
                Console.WriteLine("good morning!!");
            }
            else { Console.WriteLine("good afternoon!!"); }
            //swicth--case
            switch (DateTime.Now.Hour > 12)
            {
                case true:
                    Console.WriteLine("good morning!!");
                    break;
                case false:
                    Console.WriteLine("good afternoon!!");
                    break;
                default:
                    Console.WriteLine("good dY!!");
                    break;
            }
            //LOOP
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            int m = 1;
            while (m <= 10) 
            {
                Console.WriteLine(m);
                ++m;
            }
            int n= 1;
            do
            {
                Console.WriteLine(n);
                ++n;
            }while (n <= 10);
            //and operator
            int a = 10;
            int b = 15;
            if(a>15 && b>10)
            {
                Console.WriteLine("condition true!!");
            }
            else { Console.WriteLine("condition false!!"); }
            //or operator
            int c = 10;
            int d = 15;
            if (c > 15 || d > 10)
            {
                Console.WriteLine("condition true!!");
            }
            else { Console.WriteLine("condition false!!"); }
            //variable & arthmetic operetor
            string e = "mila";
            int f = 10 + 20;
            short g = 10 - 20;
            long h = 1134545L * 2345544L;
            float j = 12.445F / 134455F;
            decimal k = 99.99M;
            double l = 1323.1343 % 12.23234;
            Console.WriteLine($"{e} {f} {g}{h} {j} {k} {l}");
            //prefix-postfix
            int z = 15;
            Console.WriteLine(z++);//prefix
            Console.WriteLine(z);
            Console.WriteLine(++z);//postfix
            //checked-unchecked &try case
            checked
            {
                int x = int.MaxValue;
                try
                {
                    Console.WriteLine(x);
                }catch (Exception ex) 
                { Console.WriteLine(ex.Message); }
            }
            unchecked
            {
                int y = int.MaxValue;
                ++y;
                Console.WriteLine(y);

            }
            int res = Method();
            Console.WriteLine(res);
            methodep1("you are intteligent");
            methodep2("mila",23);
            scoped();
            Console.ReadKey();
        }

        private static void scoped()
        {
            int localvar = 112;
            int globalvar = 200;
            int scopvar = 300;
            Console.WriteLine($"{localvar}{globalvar}{scopvar}");
        }

        private static void methodep2(string v1, int v2)
        {
            Console.WriteLine($"{v1}{v2}");
        }

        private static void methodep1(string v)
        {
            Console.WriteLine(v);
        }

        private static int Method()
        {
            int t = 12;
            int o = 10;
            return(t+ o);
        }
    }
}
