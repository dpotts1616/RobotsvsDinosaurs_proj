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
        public Random rand = new Random();

        //constructor
        public Dinosaur(string type)
        {
            this.type = type;
            health = GetRandHealth();
            energy = 100;
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
