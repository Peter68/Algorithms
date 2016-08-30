using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MaxDrawDownAlgorithm
    {
        public int Solve(List<int> lista)
        {
            //List<int> lista = new List<int> { 14, 26, 4783000, 2124545, 125555, 145565, 14545, 24857 };

            /*  int spadek = 0;

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
           */
            int maxdd = 0;
            int max = 0;
            for (int i = 0; i < lista.Count; i++)
            {

                if (lista[i] > max)
                {
                    max = lista[i];
                }
                if (max - lista[i] > maxdd)
                {
                    maxdd = max - lista[i];
                }
            }
            return maxdd;
        }
    }
}
