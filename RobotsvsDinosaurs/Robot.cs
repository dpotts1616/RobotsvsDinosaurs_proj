using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Robot
    {
        //member variables
        public string name;
        public int health;
        public int powerLevel;
        public Weapon type;

        //constructor
        public Robot(string name, Random rand)
        {
            this.name = name;
            health = rand.Next(90,110);
            powerLevel = 100;
            type = null;
        }

        //methods

        public int Attack(Robot robot)
        {
            return robot.type.attackPower;
        }

        public bool Defend(Robot robot, int attackValue)
        {
            robot.health -= attackValue;
            if (robot.health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
