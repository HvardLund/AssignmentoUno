using AssignmentoUno.Items;
using AssignmentoUno.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentoUno.heroes
{
    public abstract class Hero
    {
        /// <summary>
        /// Base class for all other Hero-classes. Heroes can equip weapons and armor,
        /// level up, calculate total attributes and display their state. Damage is calculated in the children
        /// </summary>
        public string Name { get; set; }
        public int Level { get; set; }

        //Base attributes of a Hero
        public HeroAttributes LevelAttributes { get; set; }

        //Increase in attributes when leveling up
        public HeroAttributes ScaleAttributes { get; set; }

        //Items that are currently equipped by the hero.
        public Dictionary<Slots, Item?> HeroEquipment { get; set; }
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }

        protected Hero(string name)
        {
            Name = name;
            Level = 1;
            HeroEquipment = new Dictionary<Slots, Item?>() { [Slots.Weapon] = null, [Slots.Head] = null, [Slots.Body] = null, [Slots.Legs] = null };
            ValidWeaponTypes = new List<WeaponType>();
            ValidArmorTypes = new List<ArmorType>();
            LevelAttributes = new HeroAttributes(1, 1, 1);
            ScaleAttributes = new HeroAttributes(1, 1, 1);

        }

        /// <summary>
        /// Add a weapon to the weapon slot in HeroEquipment 
        /// </summary>
        /// <param name="Weapon"></param>
        /// <exception cref="InvalidWeaponException"></exception>
        public void Equip(Weapon Weapon)
        {
            
            if (!ValidWeaponTypes.Contains(Weapon.TypeOfWeapon))
            {
                throw new InvalidWeaponException("Wrong class");
            }

            if (Weapon.RequiredLevel > Level){
                throw new InvalidWeaponException("Not high enough level");
            }
          
            HeroEquipment[Slots.Weapon] = Weapon;

        }

        /// <summary>
        /// Add armor to HeroEquipment
        /// </summary>
        /// <param name="Armor"></param>
        /// <exception cref="InvalidArmorException"></exception>
        public void Equip(Armor Armor)
        {
            if (!ValidArmorTypes.Contains(Armor.TypeOfArmor))
            {
                throw new InvalidArmorException("Wrong class");
            }

            if (Armor.RequiredLevel > Level)
            {
                throw new InvalidArmorException("Not high enough level");
            }

            if(Armor.Slot == Slots.Weapon)
            {
                throw new InvalidArmorException("This slot is reserved for weapons");
            }

            HeroEquipment[Armor.Slot] = Armor;
        }

        /// <summary>
        /// Increase level by one. The increase in LevelAttributes is calculated on the fly in Total_attributes().
        /// </summary>
        public void Level_up()
        {
            Level++;
        }

        /// <summary>
        /// Calculate total attributes based on levelAttributes, scaleAttributes, level and equipped armor. 
        /// </summary>
        /// <returns>HeroAttributes object containing the total attributes of a hero based on level and equipped armor </returns>
        public HeroAttributes Total_attributes()
        {
            //Taking base attributes of a hero (LevelAttributes) and adding the product of scale attributes and times levelled up (level-1)
            HeroAttributes totalAttributes = LevelAttributes + new HeroAttributes(
                (Level-1) * ScaleAttributes.strength, (Level - 1) * ScaleAttributes.dexterity, (Level - 1) * ScaleAttributes.intelligence);

            //Checking for armor, and adding its attributes to the totalAttributes objects
            foreach(KeyValuePair<Slots, Item?> item in HeroEquipment)
            {
                if(item.Value is Armor)
                {
                    Armor Armor = (Armor)item.Value;
                    totalAttributes += Armor.ArmorAttributes;
                }
            }

            return totalAttributes;

        }
        public abstract double Calculate_Damage();
        /// <summary>
        /// Display core data of a hero in a human readable format
        /// </summary>
        /// <returns>String containing core data describing a hero's status</returns>
        public string Display()
        {
            StringBuilder sb = new StringBuilder("\n");
            sb.Append("Name: " + Name + "\n");
            sb.Append("Class: " + GetType().ToString().Split(".").Last() + "\n");
            sb.Append("Level: " + Level + "\n");
            sb.Append("Strength: " + Total_attributes().strength + "\n");
            sb.Append("Dexterity: " + Total_attributes().dexterity + "\n");
            sb.Append("Intelligence: " + Total_attributes().intelligence + "\n");
            sb.Append("Damage: " + Calculate_Damage()+"\n");

            return sb.ToString();
        }
    }
}
