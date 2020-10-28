using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Factories
{
    class DiceFactory
    {
        public static int setDices()
        {
            Random random = new Random();
            int dice = random.Next(0, 6);
            Console.WriteLine("your dice is: {0}", dice);
            return dice;
        }
    }
}
