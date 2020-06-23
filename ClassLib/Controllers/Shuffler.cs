using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Controllers
{
    public static class Shuffler
    {
        public static void Shuffle<T>(this IList<T> q, Random rand)
        {
            for (int i = q.Count; i > 0; i--)
            {
                q.Swap(0, rand.Next(0, i));
            }
        }

        public static void Swap<T>(this IList<T> q, int i, int j)
        {
            var temp = q[i];
            q[i] = q[j];
            q[j] = temp;
        }
    }
}
