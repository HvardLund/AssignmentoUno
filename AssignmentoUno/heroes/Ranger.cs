using AssignmentoUno.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentoUno.heroes
{
    public class Ranger:Hero
    {
        public Ranger(string name) : base(name)
        {
            //Base attributes
            LevelAttributes = new HeroAttributes(1, 7, 1);
            //Increase in attributes when levelling up
            ScaleAttributes = new HeroAttributes(1, 5, 1);
            ValidWeaponTypes = new List<WeaponType>() { WeaponType.Bows };
            ValidArmorTypes = new List<ArmorType>() { ArmorType.Leather, ArmorType.Mail };
        }

        /// <summary>
        /// Calculate damage based on the damaging attribute of the class and the equipped weapon's WeaponDamage. Weapon damage is 1 if no weapon is equipped.
        /// </summary>
        /// <returns>Amount of damage dealt by the hero</returns>
        public override double Calculate_Damage()
        {
            Weapon? Weapon = (Weapon?)HeroEquipment[Slots.Weapon];
            int damage = (Weapon != null) ? Weapon.WeaponDamage : 1;
            return damage*(1+(double)Total_attributes().dexterity/(double)100);
        }
    }
}
