using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_generic
{
    public interface IInteriordesign
    {
        void addInteriordesign(params string[] designs);
        string getInteriordesign();
    }
}
