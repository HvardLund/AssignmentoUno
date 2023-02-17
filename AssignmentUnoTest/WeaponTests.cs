using AssignmentoUno.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnoTest
{
    public class WeaponTests
    {
        [Fact]

        public void Weapon_Constructor_should_assign_Name_properly()
        {
            string name = "TestSword";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Swords;
            int damage = 1;

            Item TestWeapon = new Weapon(damage, weaponType, name, requiredLevel);

            string expected = name;
            string actual = TestWeapon.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Weapon_Constructor_should_assign_RequiredLevel_properly()
        {
            string name = "TestSword";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Swords;
            int damage = 1;

            Item TestWeapon = new Weapon(damage, weaponType, name, requiredLevel);

            int expected = requiredLevel;
            int actual = TestWeapon.RequiredLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Weapon_Constructor_should_assign_slot_properly()
        {
            string name = "TestSword";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Swords;
            int damage = 1;

            Weapon TestWeapon = new(damage, weaponType, name, requiredLevel);

            Slots expected = Slots.Weapon;
            Slots actual = TestWeapon.Slot;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Weapon_Constructor_should_assign_WeaponType_properly()
        {
            string name = "TestSword";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Swords;
            int damage = 1;

            Weapon TestWeapon = new(damage, weaponType, name, requiredLevel);

            WeaponType expected = weaponType;
            WeaponType actual = TestWeapon.TypeOfWeapon;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Weapon_Constructor_should_assign_Damage_properly()
        {
            string name = "TestSword";
            int requiredLevel = 1;
            WeaponType weaponType = WeaponType.Swords;
            int damage = 1;

            Weapon TestWeapon = new(damage, weaponType, name, requiredLevel);

            int expected = damage;
            int actual = TestWeapon.WeaponDamage;

            Assert.Equal(expected, actual);
        }
    }
}
