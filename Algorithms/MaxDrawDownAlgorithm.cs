using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MaxDrawDownAlgorithm
    {
        public int Solve(List<int> data)
        {
            int maxDrawDown = 0;
            int max = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] > max)
                {
                    max = data[i];
                }
                if (max - data[i] > maxDrawDown)
                {
                    maxDrawDown = max - data[i];
                }
            }
            return maxDrawDown;
        }
    }
}
