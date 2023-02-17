using AssignmentoUno.heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnoTest
{
    public class LevelUpTest
    {
        [Fact]
        public void Levelling_up_should_increase_level_by_one()
        {
            Hero TestHero = new Mage("Forsøkskanin");
            int level = TestHero.Level;
            int expected = level + 1;
            TestHero.Level_up();
            int actual = TestHero.Level;

            Assert.Equal(expected, actual);
        }
    }
}
