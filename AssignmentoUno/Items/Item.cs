using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentoUno.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public Slots Slot { get; set; }

        protected Item(string name, int requiredLevel)
        {
            Name = name;
            RequiredLevel = requiredLevel;
        }
    }
}
