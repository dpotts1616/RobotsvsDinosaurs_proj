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
        public int attackPower;
        public Random rand = new Random();

        //constructor
        public Robot(string name)
        {
            this.name = name;
            health = GetRandHealth();
            powerLevel = 100;
            type = null;
            attackPower = GetRandAttack();
        }

        //methods
        public int GetRandHealth()
        {
            Thread.Sleep(100);
            return rand.Next(90, 111);
        }

        public int GetRandAttack()
        {
            Thread.Sleep(100);
            return rand.Next(20, 26);
        }

        public int Attack(Robot robot)
        {
            return robot.attackPower;
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

        public void AddWeapon(int i, string choice)
        {

        }
    }
}
