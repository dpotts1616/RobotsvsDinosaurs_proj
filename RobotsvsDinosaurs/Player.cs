using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Player
    {
        //member variables

        //constructor

        //methods
        public void DisplayGameIntro()
        {
            Console.WriteLine("Welcome To Robots vs. Dinosaurs!");

        }

        public void DisplayGameStatus(Fleet roboFleet, Herd dinoHerd)
        {
            Console.Clear();
            Console.WriteLine("Battle Status");
            Console.WriteLine("The Menacing Machines!:");
            List<Robot> robots = roboFleet.robots;
            foreach (Robot robot in robots)
            {
                Console.WriteLine($"Name: {robot.name}  Health: {robot.health}  Attack Power: {robot.attackPower}");
            }
            Console.WriteLine();
            Console.WriteLine("The Dynomite Dinos!");
            List<Dinosaur> dinos = dinoHerd.dinosaur;
            foreach (Dinosaur dino in dinos)
            {
                Console.WriteLine($"Name: {dino.type}  Health: {dino.health}  Attack Power: {dino.attackPower}");
            }
        }

        public void DisplayGameEnd(Fleet roboFleet, Herd dinoHerd)
        {
            DisplayGameStatus(roboFleet, dinoHerd);
        }

        public bool PlayAgain()
        {
            bool again = true;
            while(again == true)
            {
                Console.WriteLine("Would you like to play again?");
                string input = Console.ReadLine();
                input = input.ToLower();
                if (input == "yes")
                {
                    again = true;
                    return again;
                }
                else if (input == "no")
                {
                    again = false;
                    return again;
                }
                else
                {
                    Console.WriteLine("Invalid Response: Please enter yes or no");
                }
            }
            return again;
        }
    }
}
