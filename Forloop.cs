using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Forloop
    {
        public static void forloop()
        {
            /* for (int i = 1; i <= 10; i++)
              // {
                 //  Console.WriteLine(i);
               }*/

            /*int n , n1 = 0, n2 = 1, n3;
             Console.WriteLine(n1 + " ");
             Console.WriteLine (n2 + " ");
             for ( n = 0; n < 10; n++ )
             {
                 n3 = n1 + n2;
                 Console.WriteLine(n3);
                 n1 = n2;
                 n2 = n3 ;
             } */

             int n ,  num = 75 ;
             //one condition execute multiple time 
             {
                if (num % 2 == 0)
                 {
                     Console.WriteLine("It is even number");
                 }
                 else
                 {
                     Console.WriteLine("It is odd number");
                 }
             } 
            



        }

    }

}//The C# for loop is used to iterate a part of the program several times. If the number of iteration is fixed, it is recommended to use for loop than while or do-while loops.

//The C# for loop is same as C/C++. We can initialize variable, check condition and increment/decrement value.
