using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Battlefield
    {
        //member variables
        Fleet robotFleet;
        Herd dinoHerd;
        Player player;

        //constructor
        public Battlefield()
        {
            robotFleet = new Fleet();
            dinoHerd = new Herd();
            player = new Player();
        }

        //methods
        public void CommenceBattle()
        {
            //player.DisplayGameStatus(robotFleet,dinoHerd);

            RobotAttack();
            DinoAttack();
        }

        public void RobotAttack()
        {
            int attack = robotFleet.GetAttack();
            dinoHerd.ReceiveAttack(attack);
        }

        public void DinoAttack()
        {
            int attack = dinoHerd.GetAttack();
            robotFleet.ReceiveAttack(attack);
        }
    }
}
