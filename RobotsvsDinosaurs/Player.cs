using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RobotsvsDinosaurs
{
    class Player
    {
        //member variables

        //constructor

        //methods
        public void DisplayGameIntro()
        {
            Console.Clear();
            Console.WriteLine("Welcome To Robots vs. Dinosaurs!");
            Thread.Sleep(1000);

        }

        public void DisplayGameStatus(Fleet roboFleet, Herd dinoHerd)
        {
            Console.Clear();
            Console.WriteLine("Battle Status");
            Console.WriteLine("The Menacing Machines!:");
            List<Robot> robots = roboFleet.robots;
            foreach (Robot robot in robots)
            {
                Console.Write($"Name: {robot.name}  ");
                Console.Write($"Health: {robot.health}  ");
                Console.Write($"Attack Power: {robot.attackPower}   ");
                Console.WriteLine($"Weapon: {robot.type.GetWeapon(robot)}");

            }
            Console.WriteLine();
            Console.WriteLine("The Dynomite Dinos!");
            List<Dinosaur> dinos = dinoHerd.dinosaur;
            foreach (Dinosaur dino in dinos)
            {
                Console.Write($"Name: {dino.type}   ");
                Console.Write($"Health: {dino.health}   ");
                Console.Write($"Attack Power: {dino.attackPower}    ");
                Console.WriteLine($"Energy Level: {dino.energy}");
            }
        }

        public void DisplayGameEnd(Fleet roboFleet, Herd dinoHerd)
        {
            DisplayGameStatus(roboFleet, dinoHerd);
            Console.WriteLine();
            if (roboFleet.robots.Count == 0)
            {
                Console.WriteLine("Dinosaurs Win!");
            }
            if (dinoHerd.dinosaur.Count == 0)
            {
                Console.WriteLine("Robots Win!");
            }
            Console.ReadLine();
        }

        public bool PlayAgain()
        {
            bool again = true;
            while (again == true)
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

        public void DisplayRobotAttack(Robot robot, int attack)
        {
            Console.WriteLine($"{robot.name} attacks for {attack} damage");
            Console.ReadLine();
        }

        public void DisplayDinoAttack(Dinosaur dino, int attackValue, string attackType)
        {
            Console.WriteLine($"{dino.type} uses {attackType} for {attackValue} damage");
            Console.ReadLine();
        }

        public string GetWeaponChoice(int a)
        {
            string choice;
            bool valid = false;
            do
            {
                Console.WriteLine($"What weapon would you like robot {a + 1} to have?");
                Console.WriteLine("1) Laser Sword");
                Console.WriteLine("2) Ray Gun");
                Console.WriteLine("3) Shock Cannon");
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        choice = "Laser Sword";
                        return choice;
                    case 2:
                        choice = "Ray Gun";
                        return choice;
                    case 3:
                        choice = "Shock Cannon";
                        return choice;
                    default:
                        Console.WriteLine("Invalid Response: Please enter 1, 2, or 3");
                        break;
                }
            } while (valid == false);
            return null;
        }

        public string SelectAttackType(Dinosaur dino)
        {
            bool valid = false;
            do
            {
                Console.WriteLine($"What attack would you like {dino.type} to use?");
                Console.WriteLine("1) Bite");
                Console.WriteLine("2) Stomp");
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        return "Bite";
                    case 2:
                        return "Stomp";
                    default:
                        Console.WriteLine("Sorry, that is an invalid choice, please enter 1 or 2");
                        break;
                }
            } while (valid == false);
            return null;
        }
    }
}
