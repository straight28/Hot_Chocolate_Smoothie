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

            #region + 7번문제
            //int i, k;
            //long j, result;
            //k = 0;
            //j = 2;
            //result = 0;
            //while (k < 10001)
            //{
            //    for (i = 2; i <= j; i++)
            //    {
            //        if ((j % i == 0) && (j != i))
            //        {
            //            j++;
            //            break;
            //        }
            //        else if ((j % i == 0) && (j == i))
            //        {
            //            result = j;
            //            j++;
            //            k++;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine(result);
            //Console.Write("Press any key to continue . . . ");
            //Console.ReadKey(true); 
            #endregion

            var numbers = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            var OperNumber = "";
            var tempNumber = 0;
            var maxNumber = 0;

            for (int i = 0; i < numbers.Length-4; i++)
            {
                if((numbers.Substring(i, 5)).Contains("0"))
                {
                    continue;
                }
                else
                {
                    OperNumber = numbers.Substring(i, 5);
                    tempNumber = int.Parse(OperNumber[0].ToString()) * int.Parse(OperNumber[1].ToString()) * int.Parse(OperNumber[2].ToString()) * int.Parse(OperNumber[3].ToString()) * int.Parse(OperNumber[4].ToString());
                    if(tempNumber > maxNumber)
                    {
                        maxNumber = tempNumber;
                    }
                    OperNumber = "";
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
