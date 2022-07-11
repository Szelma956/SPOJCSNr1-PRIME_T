using System;
using System.Collections.Generic;

namespace PRIME_T
{

    class PrimeNumber
    {
        public int something;

        public bool Check()
        {

            int memeory = 0;
            for (int i = something; i > 0; i--)
            {
                if (something % i == 0)
                {

                    memeory = memeory + 1;
                }

            }

            if (memeory == 2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static PrimeNumber Parse(string thing)
        {
            
            int doIT = int.Parse(thing);
            PrimeNumber obj = new PrimeNumber();
            obj.something = doIT;

            return obj;

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int NumberOfCases = int.Parse(line);

            for (int i = 0; i < NumberOfCases; i++)
            {

                string objstr = Console.ReadLine();
                PrimeNumber number = PrimeNumber.Parse(objstr);

                if (number.Check())
                {
                    Console.WriteLine("TAK");

                }
                else
                {

                    Console.WriteLine("NIE");
                }
            }
        }
    }
}
