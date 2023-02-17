using AssignmentoUno.heroes;
using AssignmentoUno.Items;
using AssignmentoUno.Utils;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnoTest
{
    public class ArmorTests
    {
        [Fact]

        public void Armor_Constructor_should_assign_Name_properly()
        {
            string name = "TestCloth";
            int requiredLevel = 1;
            ArmorType ArmorType = ArmorType.Cloth;
            HeroAttributes armorAttributes = new(0,0,0);


            Item TestArmor = new Armor(Slots.Body, ArmorType, armorAttributes, name, requiredLevel);

            string expected = name;
            string actual = TestArmor.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Armor_Constructor_should_assign_RequiredLevel_properly()
        {
            string name = "TestCloth";
            int requiredLevel = 1;
            ArmorType ArmorType = ArmorType.Cloth;
            HeroAttributes armorAttributes = new(0, 0, 0);


            Item TestArmor = new Armor(Slots.Body, ArmorType, armorAttributes, name, requiredLevel);

            int expected = requiredLevel;
            int actual = TestArmor.RequiredLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Armor_Constructor_should_assign_slot_properly()
        {
            string name = "TestCloth";
            int requiredLevel = 1;
            ArmorType ArmorType = ArmorType.Cloth;
            HeroAttributes armorAttributes = new(0, 0, 0);


            Item TestArmor = new Armor(Slots.Body, ArmorType, armorAttributes, name, requiredLevel);

            Slots expected = Slots.Body;
            Slots actual = TestArmor.Slot;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Assigning_armor_to_the_weapon_slot_should_throw_ArgumentException()
        {
            string name = "TestCloth";
            int requiredLevel = 1;
            ArmorType ArmorType = ArmorType.Cloth;
            HeroAttributes armorAttributes = new(0, 0, 0);

            Exception exception = Assert.Throws<ArgumentException>(() => new Armor(Slots.Weapon, ArmorType, armorAttributes, name, requiredLevel));

            string expected = "Armor cannot be assigned to the weapon slot";
            string actual = exception.Message;

            Assert.Equal(expected, actual);
        }
        
        [Fact]

        public void Armor_Constructor_should_assign_ArmorType_properly()
        {
            string name = "TestCloth";
            int requiredLevel = 1;
            ArmorType ArmorType = ArmorType.Cloth;
            HeroAttributes armorAttributes = new(0, 0, 0);

            Armor TestArmor = new(Slots.Body, ArmorType, armorAttributes, name, requiredLevel);

            ArmorType expected = ArmorType;
            ArmorType actual = TestArmor.TypeOfArmor;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_Constructor_should_assign_ArmorAttributes_properly()
        {
            string name = "TestCloth";
            int requiredLevel = 1;
            ArmorType ArmorType = ArmorType.Cloth;
            HeroAttributes armorAttributes = new(1, 1, 1);

            Armor TestArmor = new(Slots.Body, ArmorType, armorAttributes, name, requiredLevel);

            HeroAttributes expected = armorAttributes;
            HeroAttributes actual = TestArmor.ArmorAttributes;

            Assert.Equal(expected, actual);
        }
    }
}
