using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Herd
    {
        //member variables
        public List<Dinosaur> dinosaur = new List<Dinosaur>();

        //constructor
        public Herd()
        {
            Dinosaur dinosaur1 = new Dinosaur("Tyranosaurus");
            Dinosaur dinosaur2 = new Dinosaur("Stegosaurus");
            Dinosaur dinosaur3 = new Dinosaur("Pterydactyl");
            dinosaur.Add(dinosaur1);
            dinosaur.Add(dinosaur2);
            dinosaur.Add(dinosaur3);

        }
        //methods
        public Dinosaur GetAttack()
        {
            Dinosaur attackDino = dinosaur[0];
            return attackDino;

        }
        public void ReceiveAttack(int attack)
        {
            Dinosaur defendDino = dinosaur[0];
            bool deadDino = defendDino.Defend(defendDino, attack);
            
            if (deadDino == true)
            {
                RemoveDeadDino(defendDino);
            }
        }

        public void RemoveDeadDino(Dinosaur dino)
        {
            dinosaur.Remove(dino);
        }
    }
}
