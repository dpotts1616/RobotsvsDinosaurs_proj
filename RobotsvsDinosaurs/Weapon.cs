using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Weapon
    {
        //member variables
        public string type;
        public int attackPower;

        //constructor
        public Weapon(int name, Random rand)
        {
            if (name == 1)
            {
                type = "Laser Sword";
                attackPower = rand.Next(20, 26);

            }else if (name == 2)
            {
                type = "Ray Gun";
                attackPower = rand.Next(15, 31);
            }else if (name == 3)
            {
                type = "Shock Cannon";
                attackPower = rand.Next(5, 51);
            }
        }
        //methods
        
    }
}
