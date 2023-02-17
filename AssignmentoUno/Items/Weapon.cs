using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentoUno.Items
{
    public class Weapon:Item
    {
        /// <summary>
        /// Item equipped in the Weapon slot of a hero's equipment.
        /// </summary>
        public int WeaponDamage { get; set; }
        public WeaponType TypeOfWeapon { get; set; }


        public Weapon(int damage, WeaponType weaponType, string name, int requiredLevel):base(name, requiredLevel)
        {
            Slot = Slots.Weapon;
            WeaponDamage = damage;
            TypeOfWeapon = weaponType;
        }
    }
}
