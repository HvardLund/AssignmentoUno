using AssignmentoUno.heroes;
using AssignmentoUno.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnoTest
{
    public class TotalDamageTests
    {
        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_rogue_class_without_weapon_equipped()
        {
            
            Hero TestRogue = new Rogue("Forsøkskanin");

            double expectedDamagingAttributeValue = 6;
            double noWeaponWeaponDamage = 1;
            double expected = noWeaponWeaponDamage*(1+expectedDamagingAttributeValue/100);
            double actual = TestRogue.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_rogue_class_with_weapon_equipped()
        {
            int damage = 2;
            string name = "TestDagger";
            int requiredLevel = 1;
            Weapon TestWeapon = new(damage, WeaponType.Daggers, name, requiredLevel);

            Hero TestRogue = new Rogue("Forsøkskanin");
            TestRogue.Equip(TestWeapon);

            double expectedDamagingAttributeValue = 6;
            double expectedDamage = damage;
            double expected = expectedDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestRogue.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_rogue_class_when_reequipping_weapon()
        {
            int requiredLevel = 1;

            int damage1 = 2;
            string name1 = "TestDagger";
            Weapon TestWeapon1 = new(damage1, WeaponType.Daggers, name1, requiredLevel);

            int damage2 = 3;
            string name2 = "TestDagger2";
            Weapon TestWeapon2 = new(damage2, WeaponType.Daggers, name2, requiredLevel);

            Hero TestRogue = new Rogue("Forsøkskanin");
            TestRogue.Equip(TestWeapon1);
            TestRogue.Equip(TestWeapon2);

            double expectedDamagingAttributeValue = 6;
            double noWeaponWeaponDamage = damage2;
            double expected = noWeaponWeaponDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestRogue.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_rogue_class_with_weapon_and_armor_equipped()
        {
            int requiredLevel = 1;
            int armorDexterity = 2;

            int damage = 2;
            string weaponName = "TestDagger";
            Weapon TestWeapon = new(damage, WeaponType.Daggers, weaponName, requiredLevel);

            string armorName = "TestHat";
            HeroAttributes armorAttributes = new(0, armorDexterity, 0);
            Armor TestArmor = new(Slots.Head, ArmorType.Leather, armorAttributes, armorName, requiredLevel);

            Hero TestRogue = new Rogue("Forsøkskanin");
            TestRogue.Equip(TestWeapon);
            TestRogue.Equip(TestArmor);

            double expectedDamagingAttributeValue = 6+armorDexterity;
            double expectedDamage = damage;
            double expected = expectedDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestRogue.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_mage_class_without_weapon_equipped()
        {

            Hero TestMage = new Mage("Forsøkskanin");

            double expectedDamagingAttributeValue = 8;
            double noWeaponWeaponDamage = 1;
            double expected = noWeaponWeaponDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestMage.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_mage_class_with_weapon_equipped()
        {
            int damage = 2;
            string name = "TestWand";
            int requiredLevel = 1;
            Weapon TestWeapon = new(damage, WeaponType.Wands, name, requiredLevel);

            Hero TestMage = new Mage("Forsøkskanin");
            TestMage.Equip(TestWeapon);

            double expectedDamagingAttributeValue = 8;
            double expectedDamage = damage;
            double expected = expectedDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestMage.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_mage_class_when_reequipping_weapon()
        {
            int requiredLevel = 1;

            int damage1 = 2;
            string name1 = "TestWand";
            Weapon TestWeapon1 = new(damage1, WeaponType.Wands, name1, requiredLevel);

            int damage2 = 3;
            string name2 = "TestWand2";
            Weapon TestWeapon2 = new(damage2, WeaponType.Wands, name2, requiredLevel);

            Hero TestMage = new Mage("Forsøkskanin");
            TestMage.Equip(TestWeapon1);
            TestMage.Equip(TestWeapon2);

            double expectedDamagingAttributeValue = 8;
            double noWeaponWeaponDamage = damage2;
            double expected = noWeaponWeaponDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestMage.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_mage_class_with_weapon_and_armor_equipped()
        {
            int requiredLevel = 1;
            int armorIntelligence = 2;

            int damage = 2;
            string weaponName = "TestWand";
            Weapon TestWeapon = new(damage, WeaponType.Wands, weaponName, requiredLevel);

            string armorName = "TestHat";
            HeroAttributes armorAttributes = new(0, 0, armorIntelligence);
            Armor TestArmor = new(Slots.Head, ArmorType.Cloth, armorAttributes, armorName, requiredLevel);

            Hero TestMage = new Mage("Forsøkskanin");
            TestMage.Equip(TestWeapon);
            TestMage.Equip(TestArmor);

            double expectedDamagingAttributeValue = 8 + armorIntelligence;
            double expectedDamage = damage;
            double expected = expectedDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestMage.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_ranger_class_without_weapon_equipped()
        {

            Hero TestRanger = new Ranger("Forsøkskanin");

            double expectedDamagingAttributeValue = 7;
            double noWeaponWeaponDamage = 1;
            double expected = noWeaponWeaponDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestRanger.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_ranger_class_with_weapon_equipped()
        {
            int damage = 2;
            string name = "TestBow";
            int requiredLevel = 1;
            Weapon TestWeapon = new(damage, WeaponType.Bows, name, requiredLevel);

            Hero TestRanger = new Ranger("Forsøkskanin");
            TestRanger.Equip(TestWeapon);

            double expectedDamagingAttributeValue = 7;
            double expectedDamage = damage;
            double expected = expectedDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestRanger.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_ranger_class_when_reequipping_weapon()
        {
            int requiredLevel = 1;

            int damage1 = 2;
            string name1 = "TestBow1";
            Weapon TestWeapon1 = new(damage1, WeaponType.Bows, name1, requiredLevel);

            int damage2 = 3;
            string name2 = "TestBow2";
            Weapon TestWeapon2 = new(damage2, WeaponType.Bows, name2, requiredLevel);

            Hero TestRanger = new Ranger("Forsøkskanin");
            TestRanger.Equip(TestWeapon1);
            TestRanger.Equip(TestWeapon2);

            double expectedDamagingAttributeValue = 7;
            double noWeaponWeaponDamage = damage2;
            double expected = noWeaponWeaponDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestRanger.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_ranger_class_with_weapon_and_armor_equipped()
        {
            int requiredLevel = 1;
            int armorDexterity = 2;

            int damage = 2;
            string weaponName = "TestBow";
            Weapon TestWeapon = new(damage, WeaponType.Bows, weaponName, requiredLevel);

            string armorName = "TestHat";
            HeroAttributes armorAttributes = new(0, armorDexterity, 0);
            Armor TestArmor = new(Slots.Head, ArmorType.Leather, armorAttributes, armorName, requiredLevel);

            Hero TestRanger = new Ranger("Forsøkskanin");
            TestRanger.Equip(TestWeapon);
            TestRanger.Equip(TestArmor);

            double expectedDamagingAttributeValue = 7 + armorDexterity;
            double expectedDamage = damage;
            double expected = expectedDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestRanger.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_warrior_class_without_weapon_equipped()
        {

            Hero TestWarrior = new Warrior("Forsøkskanin");

            double expectedDamagingAttributeValue = 5;
            double noWeaponWeaponDamage = 1;
            double expected = noWeaponWeaponDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestWarrior.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_warrior_class_with_weapon_equipped()
        {
            int damage = 2;
            string name = "TestAxe";
            int requiredLevel = 1;
            Weapon TestWeapon = new(damage, WeaponType.Axes, name, requiredLevel);

            Hero TestWarrior = new Warrior("Forsøkskanin");
            TestWarrior.Equip(TestWeapon);

            double expectedDamagingAttributeValue = 5;
            double expectedDamage = damage;
            double expected = expectedDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestWarrior.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_warrior_class_when_reequipping_weapon()
        {
            int requiredLevel = 1;

            int damage1 = 2;
            string name1 = "TestAxe1";
            Weapon TestWeapon1 = new(damage1, WeaponType.Axes, name1, requiredLevel);

            int damage2 = 3;
            string name2 = "TestAxe2";
            Weapon TestWeapon2 = new(damage2, WeaponType.Axes, name2, requiredLevel);

            Hero TestWarrior = new Warrior("Forsøkskanin");
            TestWarrior.Equip(TestWeapon1);
            TestWarrior.Equip(TestWeapon2);

            double expectedDamagingAttributeValue = 5;
            double noWeaponWeaponDamage = damage2;
            double expected = noWeaponWeaponDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestWarrior.Calculate_Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Damage_should_be_calculated_correctly_in_the_warrior_class_with_weapon_and_armor_equipped()
        {
            int requiredLevel = 1;
            int armorStrength = 2;

            int damage = 2;
            string weaponName = "TestAxe";
            Weapon TestWeapon = new(damage, WeaponType.Axes, weaponName, requiredLevel);

            string armorName = "TestHat";
            HeroAttributes armorAttributes = new(armorStrength, 0, 0);
            Armor TestArmor = new(Slots.Head, ArmorType.Plate, armorAttributes, armorName, requiredLevel);

            Hero TestWarrior = new Warrior("Forsøkskanin");
            TestWarrior.Equip(TestWeapon);
            TestWarrior.Equip(TestArmor);

            double expectedDamagingAttributeValue = 5 + armorStrength;
            double expectedDamage = damage;
            double expected = expectedDamage * (1 + expectedDamagingAttributeValue / 100);
            double actual = TestWarrior.Calculate_Damage();

            Assert.Equal(expected, actual);
        }
    }
}