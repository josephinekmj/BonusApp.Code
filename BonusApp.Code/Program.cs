using System;

namespace BonusApp.Code
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello BonusApp!");

            //1.
            //  Func<int, int, int> add = (y, x) => y + x;

            //2. delegate (int x)
            //{
            //    int result = 0;
            //    for (int i = 0; i < 10; i++)
            //    {
            //        result += x;
            //    }
            //};


            Action<int> forLoopTillTen = x => 
            { int result = 0;

                 for (int i = 0; i < 10; i++)
                 {
                      result += x;
                    Console.WriteLine("Resulatet er: " + result);
                 }

                 
            };


            forLoopTillTen(4);


            /* 3:

                 delegate (int x)
                 {
                     return x * x;
                 }; 
            */

            Func<int, int> square = x => x * x;

        }
    }
}
