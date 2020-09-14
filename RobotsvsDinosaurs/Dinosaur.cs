using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Dinosaur
    {
        //member variables
        string type;
        int health;
        int energy;
        int attackPower;
        Random rand = new Random();

        //constructor
        public Dinosaur(string type)
        {
            this.type = type;
            health = rand.Next(90,110);
            energy = 100;
            attackPower = rand.Next(20,25);
        }

        //methods
        public int Attack(Dinosaur dinosaur)
        {
            return dinosaur.attackPower;
        }

        public bool Defend(Dinosaur dinosaur, int attackValue)
        {
            dinosaur.health -= attackValue;
            if (dinosaur.health < 0)
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
