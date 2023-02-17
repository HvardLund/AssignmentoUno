using AssignmentoUno.heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentoUno.Items
{
    public class Armor:Item
    {

        public HeroAttributes ArmorAttributes { get; set; }
        public ArmorType TypeOfArmor { get; set; }

        public Armor(Slots slot, ArmorType armorType, HeroAttributes armorAttributes, string name, int requiredLevel) : base(name, requiredLevel)
        {
            if (slot == Slots.Weapon)
            {
                throw new ArgumentException("Armor cannot be assigned to the weapon slot");
            }
            ArmorAttributes = armorAttributes;
            TypeOfArmor = armorType;
            Slot = slot;
        }

    }
}
