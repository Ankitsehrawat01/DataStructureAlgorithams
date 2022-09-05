using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSttructureAlgorithams
{
    public class PrimeNumber
    {
        public void Numbers()
        {
            Console.WriteLine("Prime numbers from 0 to 1000 are:  ");
            int n = 1000;
            bool check;
            for (int i = 0; i <= n; i++)
            {
                if (i == 1 || i == 0)
                {
                    continue;
                }

                check = true;
                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
