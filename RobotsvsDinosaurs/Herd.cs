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
        public List<Dinosaur> dinosaur;

        //constructor
        public Herd(Random rand)
        {
            dinosaur = new List<Dinosaur>();
            dinosaur.Add(new Dinosaur("Tyranosaurus", rand));
            dinosaur.Add(new Dinosaur("Stegosaurus", rand));
            dinosaur.Add(new Dinosaur("Pterydactyl", rand));

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
