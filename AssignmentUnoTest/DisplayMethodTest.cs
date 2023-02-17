using AssignmentoUno.heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentUnoTest
{
    public class DisplayMethodTest
    {
        [Fact]

        public void Display_method_should_display_Name_Class_Level_total_trength_total_dexterity_total_intelligence_and_Damage_correctly()
        {
            string name = "\nName: " + "Forsøkskanin" + "\n";
            string heroClass = "Class: " + "Mage" + "\n";
            string level = "Level: " + 1 + "\n";
            string strength = "Strength: " + 1 + "\n";
            string dexterity = "Dexterity: " + 1 + "\n";
            string intelligence = "Intelligence: " + 8 + "\n";
            double damageAmount = 1.0 + 8.0 / 100.0;
            string damage = "Damage: " + damageAmount.ToString() + "\n";

            string expected = name + heroClass + level + strength + dexterity + intelligence + damage;

            Hero TestMage = new Mage("Forsøkskanin");
            string actual = TestMage.Display();

            Assert.Equal(expected, actual);
        }
    }
}
