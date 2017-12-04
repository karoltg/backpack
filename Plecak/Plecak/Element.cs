using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plecak
{
    public class Element
    {

        public int weight { set; get; }
        public int price { set; get; }
        public int elementCount { set; get; }

        public Element() {}
        public Element(int weight, int price, int elementCount = 1)
        {
            this.weight = weight;
            this.price = price;
            this.elementCount = elementCount;
        }

        

    }
}
