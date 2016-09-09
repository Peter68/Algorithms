using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = new List<int>() { 5555, 21, 54, 4 }; //Możesz też zrobić wczytywanie z konsoli

            var maxDrawDownAlgorithm = new MaxDrawDownAlgorithm();

            var result = maxDrawDownAlgorithm.Solve(data);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
