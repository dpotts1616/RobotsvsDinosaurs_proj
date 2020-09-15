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
            player.DisplayGameIntro();
            bool again = true;
            while (again == true)
            {
                while (robotFleet.robots.Count > 0 && dinoHerd.dinosaur.Count > 0)
                {
                    player.DisplayGameStatus(robotFleet, dinoHerd);
                    RunBattleSequence();
                    Console.ReadLine();
                }
                player.DisplayGameEnd(robotFleet, dinoHerd);
                again = player.PlayAgain();
            }
        }

        public void RunBattleSequence()
        {
            if(robotFleet.robots.Count > 0)
            {
                RobotAttack();
            }
            if(dinoHerd.dinosaur.Count > 0)
            {
                DinoAttack();
            }
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
