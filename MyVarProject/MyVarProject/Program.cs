using System;


namespace VariablesProj
{
    class Program
    {

        static void Main(string[] args)
        {

            int myVal = 7;




            myVal = -1 + 4 * myVal;

            Console.WriteLine(myVal);

            myVal = (35 + 5) % myVal;

            Console.WriteLine(myVal);

            myVal = 14 + -4 * 6 / 12;

            Console.WriteLine(myVal);

            myVal /= 2 + 12 / 6 * 1 - myVal % 2;

            Console.WriteLine(myVal);



            {
                int myVal2 = 0;

                myVal2 *= myVal * myVal;


            
            if (myVal2 > 10)
                {
                    Console.WriteLine("My Var is greater than 10");
                }
                else
                {
                    Console.WriteLine("My Var is less than 10");
                }
            }




        }
    }
}
