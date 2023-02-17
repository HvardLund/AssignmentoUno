using AssignmentoUno.Items;
using AssignmentoUno.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentoUno.heroes
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HeroAttributes LevelAttributes { get; set; }
        public HeroAttributes ScaleAttributes { get; set; }
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
        public HeroAttributes Total_attributes()
        {
            HeroAttributes totalAttributes = LevelAttributes + new HeroAttributes(
                (Level-1) * ScaleAttributes.strength, (Level - 1) * ScaleAttributes.dexterity, (Level - 1) * ScaleAttributes.intelligence);

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
        public void Level_up()
        {
            Level ++;
        }
        public abstract double Calculate_Damage();
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
