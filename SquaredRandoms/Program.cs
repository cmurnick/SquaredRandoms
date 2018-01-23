using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = RandomNumberList();
            var squaredList = new List<int>();

            foreach ( var number in list)
            {
                
                var squaredNumber = number * number;
                
                var even = squaredNumber % 2 == 0;
                if(even) 
                {
                    //if it's odd, I don't want it to print to the screen
                    squaredList.Add(squaredNumber);
                    Console.WriteLine(squaredNumber);
                }
                
            }
             Console.ReadLine();
        }

        private static List<int> RandomNumberList()
        {
            var count = 20;
            Random rnd = new Random();
            List<int> result = new List<int>();
            //var strings = new List<int>();

            for (int i = 0; i < count; i++)
            {

                var randomNumber = rnd.Next(1, 51);
                result.Add(randomNumber);

            }

            return result;
        }
    }
}
