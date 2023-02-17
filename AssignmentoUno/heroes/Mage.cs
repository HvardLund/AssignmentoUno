using AssignmentoUno.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentoUno.heroes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            //Base attributes
            LevelAttributes = new HeroAttributes(1, 1, 8);
            //Increase in attributes when levelling up
            ScaleAttributes = new HeroAttributes(1, 1, 5);
            ValidWeaponTypes = new List<WeaponType>() { WeaponType.Staffs, WeaponType.Wands};
            ValidArmorTypes = new List<ArmorType>() {ArmorType.Cloth};
        }

        /// <summary>
        /// Calculate damage based on the damaging attribute of the class and the equipped weapons WeaponDamag'e. Weapon damage is 1 if no weapon is equipped.
        /// </summary>
        /// <returns>Amount of damage dealt by the hero</returns>
        public override double Calculate_Damage()
        {
            Weapon? Weapon = (Weapon?)HeroEquipment[Slots.Weapon];
            double damage = (Weapon != null) ? Weapon.WeaponDamage : 1;
            return damage * (1 + (double)Total_attributes().intelligence / (double)100);
        }
    }
}