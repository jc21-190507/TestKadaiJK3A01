using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211210
{
    public class DirectedE
    {

        public static int[] SEARCH(int[] edgeFirst, int[] edgeNext, int x)
        {
            int N = 6;
            int M = 8;


            int[] current = new int[N];
            int[] searched = new int[M];
            int[] path = new int[M];

            int[] start = new int[] { 1, 2, 3, 4, 2, 5, 4, 6 };
            int[] end = new int[] { 2, 3, 4, 1, 5, 4, 6, 2 };

            //各点での未探索の辺の番号を初期化
            for (int i = 0; i < N; i++)
            {
                current[i] = edgeFirst[i];
            }

            int top = 1;
            int last = M;
            int temp = 0;

            while (last >= 1)
            {
                if (current[x - 1] != 0)
                {
                    temp = current[x - 1];
                    searched[top - 1] = temp;
                    current[x - 1] = edgeNext[temp - 1];
                    x = end[temp - 1];

                    top++;
                }

                else
                {
                    top--;

                    temp = searched[top - 1];
                    path[last - 1] = temp;
                    x = start[temp - 1];

                    last--;
                }
            }

            return path;
        }
    }
}
