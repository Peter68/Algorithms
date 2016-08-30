using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace AlgorithmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<int>() { 14, 26, 555, 243, 10, 20, 30, 4533 }; //Możesz też zrobić wczytywanie z konsoli

            var maxDrawDownAlgorithm = new MaxDrawDownAlgorithm();

            var result = maxDrawDownAlgorithm.Solve(data);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
