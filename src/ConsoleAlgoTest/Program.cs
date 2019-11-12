using System;
using System.Collections.Generic;

namespace ConsoleAlgoTest
{
    class Program
    {
        static void Main(string[] args)
        {

            #region + 6번문제
            //int sum1 = 0;
            //int sum2 = 0;
            //
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum1 += (i * i);
            //    sum2 += i;
            //}
            //sum2 *= sum2;
            //int result = sum2 - sum1;
            //
            //Console.WriteLine("6번답은 "+ result);
            #endregion

            int i, k;
            long j, result;

            k = 0;
            j = 2;
            result = 0;


            while (k < 10001)
            {

                for (i = 2; i <= j; i++)
                {

                    if ((j % i == 0) && (j != i))
                    {
                        j++;
                        break;
                    }
                    else if ((j % i == 0) && (j == i))
                    {
                        result = j;
                        j++;
                        k++;
                        break;
                    }

                }
            }

            Console.WriteLine(result);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        }
    }
}
