using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI_Lab3
{
    class Item
    {
        private string name;
        private int cost;
        private string unit;


        public Item(string name, int cost, string unit = "шт.")
        {
            this.name = name;
            this.cost = cost;
            this.unit = unit;
        }


        public string Name => name;
        public int Cost => cost;
        public string Unit => unit;
    }
}
