using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI_Lab3
{
    class Category
    {
        private string name;
        private string valueMember;//test
        private List<Item> items;


        public Category(string name, List<Item> items)
        {
            this.name = name;
            this.items = items;
        }


        public string Name => name;
        public string ValueMember => "ValueMember";//test
        public List<Item> Items => items;
    }
}
