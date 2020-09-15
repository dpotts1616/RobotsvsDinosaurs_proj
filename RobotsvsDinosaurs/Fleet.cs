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
        public List<Robot> robots = new List<Robot>();

        //constructor
        public Fleet()
        {
            Robot robot1 = new Robot("DJ Roomba");
            Robot robot2 = new Robot("Bender Rodriguez");
            Robot robot3 = new Robot("C-3P-Oh No You Didn't");
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);

        }

        //methods
        public int GetAttack()
        {
            Robot attackRobot = robots[0];
            int attack = attackRobot.Attack(attackRobot);
            return attack;
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



    }
}
