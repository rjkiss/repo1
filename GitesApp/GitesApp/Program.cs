using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            Motor motor = new Motor();
            Bicikli bicikli = new Bicikli();
            auto.Drive();
            motor.Drive();
            bicikli.Drive();

            Console.ReadLine();
        }
    }
}
