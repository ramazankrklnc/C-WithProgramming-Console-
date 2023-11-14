using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classs_and_Object_1
{
    internal class Customer
    {
        public int Id;
        private string name;
        private string surname;
        public string city;

        public string Name { get => name; set => name = value.ToLower(); }
        public string Surname { get => surname; set => surname = value.ToUpper(); }


    }
}
