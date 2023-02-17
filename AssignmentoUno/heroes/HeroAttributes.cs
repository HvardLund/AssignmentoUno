using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentoUno.heroes
{
    public class HeroAttributes
    {
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int intelligence{ get; set; }

        public HeroAttributes(int strength, int dexterity, int intelligence)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }

        public void updateAttributes(int strength, int dexterity, int intelligence)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }

        public static HeroAttributes operator + (HeroAttributes lhs, HeroAttributes rhs) 
        {
            return new HeroAttributes(lhs.strength + rhs.strength, lhs.dexterity + rhs.dexterity, lhs.intelligence + rhs.intelligence);
        }
    }
}
