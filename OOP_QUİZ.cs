using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objejct_Oriented_Programing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num;
            int counter=1;
            int sum;

            while (counter < 5)
            {
                Console.Write("please enter a number:");
                num=Convert.ToInt32(Console.ReadLine());
                

                
                sum += num;
                counter++;
                Console.WriteLine("sum",sum);
            }
            

           /*

            /*

            
            int num;
            int sum=0;
            while (true) {
                Console.Write("please enter a num:");
                num = Convert.ToInt32(Console.ReadLine());


                if (num < 0)
                
                  break;
                if (num % 2 != 0)
                  { 
                      sum += num;

                  }
                
             
            }

         Console.WriteLine("total: {0}", sum);
*/


            // largest and second largest numbers entered until -1 is entered form the keyboard.




            int max1 = 0;
            int max2 = 0;   

            
            int number;
            while (1 == 1) //sonsuz döngü
            {
                Console.Write("please enter a num:");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == -1)
                {
                    break;

                }
                if (number > max1)
                {
                    max2 = max1;
                    max1 = number;
                }
                else if (number > max2)
                {
                    max2 = number;
                }

                {

                    Console.WriteLine(max1);
                    Console.WriteLine(max2);

                }





            }

























            }
    }
}
