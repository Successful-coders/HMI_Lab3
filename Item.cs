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


        public Item(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }


        public string Name => name;
        public int Cost => cost;
    }
}
