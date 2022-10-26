using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShop.ClassHelper
{
    internal class EFClass
    {
        public static Entities Context { get; set; } = new Entities();
    }
}
