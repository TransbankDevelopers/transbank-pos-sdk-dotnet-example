using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransbankPosSDKExample
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public string[] Row => new string[] {Name, Price.ToString() };
    }
}
