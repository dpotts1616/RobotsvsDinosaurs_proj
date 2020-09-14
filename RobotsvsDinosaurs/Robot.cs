using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Robot
    {
        //member variables
        string name;
        int health;
        int powerLevel;
        Weapon type;
        int attackPower;
        Random rand = new Random();

        //constructor
        public Robot(string name)
        {
            this.name = name;
            health = rand.Next(90,110);
            powerLevel = 100;
            type = new Weapon();
            attackPower = rand.Next(20,25);
        }

        //methods
        public int Attack(Robot robot)
        {
            return robot.attackPower;
        }

        public bool Defend(Robot robot, int attackValue)
        {
            robot.health -= attackValue;
            if (robot.health < 0)
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
