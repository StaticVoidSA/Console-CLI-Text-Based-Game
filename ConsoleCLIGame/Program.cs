using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCLIGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Levels myLevels = new Levels();

            myLevels.start();

            Console.ReadLine();
        }
    }
}
