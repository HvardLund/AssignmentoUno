using AssignmentoUno.heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnoTest
{
    public class HeroConstructorTests
    {
        [Fact]
        public void Constructor_should_assign_Name_properly()
        {
            string name = "Forsøkskanin";
            Hero TestHero = new Mage(name);

            string expected = name;
            string actual = TestHero.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Constructor_should_assign_Level_properly()
        {
            Hero TestHero = new Mage("Forsøkskanin");

            int expected = 1;
            int actual = TestHero.Level;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Mage_constructor_should_assign_LevelAttributes_properly()
        {
            Hero TestMage = new Mage("Forsøkskanin");

            HeroAttributes? actual = TestMage.LevelAttributes;
            HeroAttributes expected = new(1, 1, 8);

            Assert.Equivalent(expected, actual);
        }

        [Fact]

        public void Mage_constructor_should_assign_ScaleAttributes_properly()
        {
            Hero TestMage = new Mage("Forsøkskanin");

            HeroAttributes? actual = TestMage.ScaleAttributes;
            HeroAttributes expected = new(1, 1, 5);

            Assert.Equivalent(expected, actual);
        }

        [Fact]

        public void Ranger_constructor_should_assign_LevelAttributes_properly()
        {
            Hero TestRanger = new Ranger("Forsøkskanin");

            HeroAttributes? actual = TestRanger.LevelAttributes;
            HeroAttributes expected = new(1, 7, 1);

            Assert.Equivalent(expected, actual);
        }

        [Fact]

        public void Ranger_constructor_should_assign_ScaleAttributes_properly()
        {
            Hero TestRanger = new Ranger("Forsøkskanin");

            HeroAttributes? actual = TestRanger.ScaleAttributes;
            HeroAttributes expected = new(1, 5, 1);

            Assert.Equivalent(expected, actual);
        }

        [Fact]

        public void Rogue_constructor_should_assign_LevelAttributes_properly()
        {
            Hero TestRogue = new Rogue("Forsøkskanin");

            HeroAttributes? actual = TestRogue.LevelAttributes;
            HeroAttributes expected = new(2, 6, 1);

            Assert.Equivalent(expected, actual);
        }

        [Fact]

        public void Rogue_constructor_should_assign_ScaleAttributes_properly()
        {
            Hero TestRogue = new Rogue("Forsøkskanin");

            HeroAttributes? actual = TestRogue.ScaleAttributes;
            HeroAttributes expected = new(1, 4, 1);

            Assert.Equivalent(expected, actual);
        }

        [Fact]

        public void Warrior_constructor_should_assign_LevelAttributes_properly()
        {
            Hero TestWarrior = new Warrior("Forsøkskanin");

            HeroAttributes? actual = TestWarrior.LevelAttributes;
            HeroAttributes expected = new(5, 2, 1);

            Assert.Equivalent(expected, actual);
        }

        [Fact]

        public void Warrior_constructor_should_assign_ScaleAttributes_properly()
        {
            Hero TestWarrior = new Warrior("Forsøkskanin");

            HeroAttributes? actual = TestWarrior.ScaleAttributes;
            HeroAttributes expected = new(3, 2, 1);

            Assert.Equivalent(expected, actual);
        }
    }
}
