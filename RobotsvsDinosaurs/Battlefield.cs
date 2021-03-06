﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Battlefield
    {
        //member variables
        Fleet robotFleet;
        Herd dinoHerd;
        Player player;
        Random rand = new Random();
        public int side;

        //constructor
        public Battlefield()
        {
            robotFleet = new Fleet(rand);
            dinoHerd = new Herd(rand);
            player = new Player();
        }

        //methods
        public void CommenceBattle()
        {
            player.DisplayGameIntro();
            robotFleet = OutfitRobotArmy(rand);
            
            while (robotFleet.robots.Count > 0 && dinoHerd.dinosaur.Count > 0)
            {
                player.DisplayGameStatus(robotFleet, dinoHerd);
                Console.ReadLine();
                RunBattleSequence();
            }
            player.DisplayGameEnd(robotFleet, dinoHerd);
        }

        public void RunBattleSequence()
        {
            side = rand.Next(1, 3);
            if (side == 1)
            {
                RobotsAttackFirst();
            }
            else if (side == 2)
            {
                DinosAttackFirst();
            }
        }

        public void RobotsAttackFirst()
        {
            RobotAttack();
            if (dinoHerd.dinosaur.Count > 0)
            {
                DinoAttack();
            }
        }

        public void DinosAttackFirst()
        {
            DinoAttack();
            if (robotFleet.robots.Count > 0)
            {
                RobotAttack();
            }
        }

        public void RobotAttack()
        {
            Robot robot = robotFleet.GetAttack();
            player.DisplayRobotAttack(robot, robot.type.attackPower);
            dinoHerd.ReceiveAttack(robot.type.attackPower);
        }

        public void DinoAttack()
        {
            Dinosaur dino = dinoHerd.GetAttack();
            int attack = player.SelectAttackType(dino);
            dino.energy -= 10;
            player.DisplayDinoAttack(dino, dino.attackPower, attack);
            robotFleet.ReceiveAttack(dino.attackPower);
        }

        public bool PlayAgain()
        {
            bool again = player.PlayAgain();
            return again;
        }

        public Fleet OutfitRobotArmy(Random rand)
        {


            for (int i = 0; i < 3; i++)
            {
                int choice = player.GetWeaponChoice(i);
                Robot robot = robotFleet.AssignWeapon(i, choice, rand);
                robotFleet.robots[i] = robot;
            }

            return robotFleet;
        }
    }
}
