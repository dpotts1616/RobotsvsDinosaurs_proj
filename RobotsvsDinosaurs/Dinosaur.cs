using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Dinosaur
    {
        //member variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        public string[] attackArray;

        //constructor
        public Dinosaur(string type, Random rand)
        {
            this.type = type;
            health = rand.Next(80, 120);
            energy = 100;
            attackPower = rand.Next(20, 31);
            attackArray = new string[2] { "Bite", "Stomp" };
        }

        //methods
        public int Attack(Dinosaur dinosaur)
        {
            return dinosaur.attackPower;
        }

        public bool Defend(Dinosaur dinosaur, int attackValue)
        {
            dinosaur.health -= attackValue;
            if (dinosaur.health <= 0)
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
