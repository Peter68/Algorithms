using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MaxDrawDownAlgorithm
    {
       public static int Solve(List<int> lista)
        {
            int spadek = 0;
          //  List<int> lista = new List<int> { 14, 26, 4783000, 2124545, 125555, 145565, 14545, 24857 };

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i] > lista[j])
                    {

                        if ((lista[i] - lista[j]) > spadek)
                        {
                            spadek = lista[i] - lista[j];
                        }
                    }
                }

            }
            return spadek;
        }
    }
}
