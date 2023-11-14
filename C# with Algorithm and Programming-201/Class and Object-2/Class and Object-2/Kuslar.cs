using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Object_2
{
    internal class Kuslar
    {
        public string tur;
        public int hiz;
        public double agirlik;
        public virtual string sescikar()
        {
            return "Buraya ses yazılacak";
        }
    }
}
