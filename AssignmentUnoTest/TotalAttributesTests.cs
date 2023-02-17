using AssignmentoUno.heroes;
using AssignmentoUno.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnoTest
{
    public class TotalAttributesTests
    {
        [Fact]

        public void Total_attributes_should_be_calculated_correctly_when_no_items_are_equipped()
        {
            HeroAttributes expected = new(1, 1, 8);
            Hero TestHero = new Mage("Forsøkskanin");
            HeroAttributes actual = TestHero.Total_attributes();

            Assert.Equivalent(expected, actual);
        }

        [Fact]

        public void Total_attributes_should_be_calculated_correctly_after_levelling_up()
        {
            Hero TestHero = new Mage("Forsøkskanin");
            HeroAttributes initialValues = TestHero.LevelAttributes;
            HeroAttributes scaleAttributes = new(1, 1, 5);
            
            HeroAttributes expected = initialValues + scaleAttributes;
            TestHero.Level_up();
            HeroAttributes actual = TestHero.Total_attributes();

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Total_attributes_should_be_calculated_correctly_when_one_piece_of_armor_is_equipped()
        {
            Hero TestHero = new Mage("Forsøkskanin");
            HeroAttributes initialValues = TestHero.LevelAttributes;

            string name = "TestCloth";
            int requiredLevel = 1;
            ArmorType ArmorType = ArmorType.Cloth;
            HeroAttributes armorAttributes = new(1, 2, 3);
            Armor TestArmor = new Armor(Slots.Body, ArmorType, armorAttributes, name, requiredLevel);

            TestHero.Equip(TestArmor);

            HeroAttributes expected = initialValues + armorAttributes;
            HeroAttributes actual = TestHero.Total_attributes();

            Assert.Equivalent(expected, actual);

        }

        [Fact]
        public void Total_attributes_should_be_calculated_correctly_when_two_pieces_of_armor_are_equipped()
        {
            Hero TestHero = new Mage("Forsøkskanin");
            HeroAttributes initialValues = TestHero.LevelAttributes;

            int requiredLevel = 1;
            ArmorType ArmorType = ArmorType.Cloth;

            string name1 = "TestCloth1";
            HeroAttributes armorAttributes1 = new(1, 2, 3);
            Armor TestArmor1 = new Armor(Slots.Body, ArmorType, armorAttributes1, name1, requiredLevel);

            string name2 = "TestCloth2";
            HeroAttributes armorAttributes2 = new(3, 2, 1);
            Armor TestArmor2 = new Armor(Slots.Head, ArmorType, armorAttributes2, name2, requiredLevel);

            TestHero.Equip(TestArmor1);
            TestHero.Equip(TestArmor2);

            HeroAttributes expected = initialValues + armorAttributes1 + armorAttributes2;
            HeroAttributes actual = TestHero.Total_attributes();

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Total_attributes_should_be_calculated_correctly_when_Armor_is_replaced()
        {
            Hero TestHero = new Mage("Forsøkskanin");
            HeroAttributes initialValues = TestHero.LevelAttributes;

            int requiredLevel = 1;
            ArmorType ArmorType = ArmorType.Cloth;

            string name1 = "TestCloth1";
            HeroAttributes armorAttributes1 = new(1, 2, 3);
            Armor TestArmor1 = new Armor(Slots.Body, ArmorType, armorAttributes1, name1, requiredLevel);

            string name2 = "TestCloth2";
            HeroAttributes armorAttributes2 = new(3, 2, 1);
            Armor TestArmor2 = new Armor(Slots.Body, ArmorType, armorAttributes2, name2, requiredLevel);

            TestHero.Equip(TestArmor1);
            TestHero.Equip(TestArmor2);

            HeroAttributes expected = initialValues + armorAttributes2;
            HeroAttributes actual = TestHero.Total_attributes();

            Assert.Equivalent(expected, actual);
        }
    }
}
