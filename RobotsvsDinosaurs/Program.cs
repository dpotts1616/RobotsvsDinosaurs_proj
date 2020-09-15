using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {

            bool again;
            do
            {
                Battlefield battlefield = new Battlefield();

                battlefield.CommenceBattle();

                again = battlefield.PlayAgain();

            } while (again == true);



            Console.ReadLine();
        }
    }
}
