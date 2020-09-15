using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Fleet
    {
        //member variables
        public List<Robot> robots;

        //constructor
        public Fleet(Random rand)
        {
            robots = new List<Robot>();
            robots.Add(new Robot("DJ Roomba", rand));
            robots.Add(new Robot("Bender Rodriguez", rand));
            robots.Add(new Robot("R2-Destroy", rand));

        }

        //methods
        public Robot GetAttack()
        {
            Robot attackRobot = robots[0];
            return attackRobot;
        }

        public void ReceiveAttack(int attack)
        {
            Robot defendRobot = robots[0];
            bool deadBot = defendRobot.Defend(defendRobot, attack);
            if (deadBot == true)
            {
                RemoveDeadRobot(defendRobot);
            }
        }

        //remove dead robot from fleet
        public void RemoveDeadRobot(Robot robot)
        {
            robots.Remove(robot);
        }

        public Robot AssignWeapon(int i, int choice, Random rand)
        {
            Robot robot = robots[i];
            Weapon weapon = new Weapon(choice, rand);
            robot.type = weapon;
            return robot;

        }

    }
}
