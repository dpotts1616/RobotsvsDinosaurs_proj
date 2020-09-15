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
        string type;

        //constructor
        public Weapon(string type)
        {
            this.type = type;
        }
        //methods
        public string GetWeapon(Robot robot)
        {
            return robot.type.type;
        }
    }
}
