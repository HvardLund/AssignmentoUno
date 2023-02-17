using AssignmentoUno.heroes;
using AssignmentoUno.Items;
using AssignmentoUno.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnoTest
{
    public class EquipTests
    {
        [Fact]

        public void Equipping_legal_weapon_should_add_weapon_to_heroEquipment()
        {
            int damage = 1;
            string name = "TestWand";
            int requiredLevel = 1;

            Hero TestHero = new Mage("Forsøkskanin");
            Weapon TestWeapon = new(damage, WeaponType.Wands, name, requiredLevel);

            Weapon expected = TestWeapon;

            TestHero.Equip(TestWeapon);
            Item? actual = TestHero.HeroEquipment[Slots.Weapon];

            Assert.Equal(expected, actual);

        }

        [Fact]

        public void Equipping_weapon_that_is_not_in_validWeaponTypes_should_throw_InvalidWeaponException()
        {
            int damage = 1;
            string name = "TestWand";
            int requiredLevel = 1;

            Hero TestHero = new Mage("Forsøkskanin");
            Weapon TestWeapon = new(damage, WeaponType.Swords, name, requiredLevel);

            Exception exception = Assert.Throws<InvalidWeaponException>(() => TestHero.Equip(TestWeapon));
            string expected = "Wrong class";
            string actual = exception.Message;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Equipping_weapon_when_RequiredLevel_is_higher_than_Level_should_throw_InvalidWeaponException() 
        {
            int damage = 1;
            string name = "TestWand";

            Hero TestHero = new Mage("Forsøkskanin");
            int requiredLevel = TestHero.Level+1;
            Weapon TestWeapon = new(damage, WeaponType.Wands, name, requiredLevel);

            Exception exception = Assert.Throws<InvalidWeaponException>(() => TestHero.Equip(TestWeapon));
            string expected = "Not high enough level";
            string actual = exception.Message;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Equipping_legal_armor_should_add_armor_to_heroEquipment()
        {
            string name = "TestHat";
            int requiredLevel = 1;
            HeroAttributes armorAttributes = new(1, 1, 1);

            Hero TestHero = new Mage("Forsøkskanin");
            Armor TestArmor = new(Slots.Head, ArmorType.Cloth, armorAttributes, name, requiredLevel);

            Armor expected = TestArmor;

            TestHero.Equip(TestArmor);
            Item? actual = TestHero.HeroEquipment[Slots.Head];

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Equipping_Armor_that_is_not_in_validArmorTypes_should_throw_InvalidArmorException()
        {
            string name = "TestHat";
            int requiredLevel = 1;
            HeroAttributes armorAttributes = new(1, 1, 1);

            Hero TestHero = new Mage("Forsøkskanin");
            Armor TestArmor = new(Slots.Head, ArmorType.Plate, armorAttributes, name, requiredLevel);

            Exception exception = Assert.Throws<InvalidArmorException>(() => TestHero.Equip(TestArmor));
            string expected = "Wrong class";
            string actual = exception.Message;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Equipping_Armor_when_RequiredLevel_is_higher_than_Level_should_throw_InvalidArmorException()
        {
            string name = "TestHat";
            HeroAttributes armorAttributes = new(1, 1, 1);

            Hero TestHero = new Mage("Forsøkskanin");
            int requiredLevel = TestHero.Level + 1;
            Armor TestArmor = new(Slots.Head, ArmorType.Cloth, armorAttributes, name, requiredLevel);

            Exception exception = Assert.Throws<InvalidArmorException>(() => TestHero.Equip(TestArmor));
            string expected = "Not high enough level";
            string actual = exception.Message;

            Assert.Equal(expected, actual);
        }
    }
}
