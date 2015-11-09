using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituteIFsWithMessages
{
    class Program
    {        
        static void Main(string[] args)
        {
            GatherConditions()
                .ToList()
                .ForEach(condition =>
                {
                    Test1(condition);
                    Test2(condition);
                });

            Console.ReadLine();
        }

        static IEnumerable<bool> GatherConditions() {
            yield return 1 == 1;
            yield return 1 == 2;
        }


        private static void Test1(bool condition)
        {
            Console.WriteLine("Test1");
            if (condition)
            {
                Console.WriteLine("That's true");
            }
            else
            {
                Console.WriteLine("That's false");
            }
        }

        private static void Test2(bool condition)
        {
            Console.WriteLine("Test2");
            condition.IfTrue(() => Console.WriteLine("That's true"));
            condition.IfFalse(() => Console.WriteLine("That's false"));            
        }
    }
}
