using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
   public interface IExteriordesign
    {
        void addExteriordesign(params string[] design);
        string  getExteriordesign();
    }
}
