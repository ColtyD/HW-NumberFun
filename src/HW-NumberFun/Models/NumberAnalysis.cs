using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NumberFun.Models
{
        public class NumberAnalysis
        {
        public int Number { get; set; }
        public string Prime { get; set; }
        public string Perfect { get; set; }
        public string Squareful { get; set; }
        public string Powerful { get; set; }
        public string Plaindromic { get; set; }

        public NumberAnalysis(int n)
            {
                Number = n;
            }

        // Check if the number is Prime
            public bool isPrime()
            {
                int modCount = 0;
                for (int i = 1; i <= Number; i++)
                {
                    if (Number % i == 0)
                    {
                        modCount++;
                    }
                }
                if (modCount == 2)
                {
                    Prime = "The number is Prime!";
                    return true;
                }
                else
                {
                    Prime = "The number is NOT Prime!";
                    return false;
                }


            }

        //Check to see if the number is a Perfect number
            public bool isPerfect()
            {
                int sum = 0;
                for (int i = 1; i < Number; i++)
                {
                    if (Number % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (sum == Number)
                {
                    Perfect = "The number is Perfect!";
                    return true;
                }
                else
                {
                    Perfect = "The number is NOT Perfect!";
                    return false;
                }
            }

        // I needed another Prime function to use in the Squareful and Powerful functions
        private bool isPrime(int number)
        {
            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        // Check to see if the number is Squareful 
        // At least one prime factor of the number is repeated.
        public bool isSquareful()
            {
                for (int i = 1; i <= Number; i++)
                {
                    if (Number % i == 0)
                    {
                        if (isPrime(i) == true)
                        {
                            if (Number % (i * i) == 0)
                            {
                            Squareful = "The number is Squareful!";
                                return true;
                            }

                        }
                    }
                }
            Squareful = "The number is NOT Squareful!";
            return false;
            }

        // Check to see if the number is Powerful
            public bool isPowerful()
            {
                for (int i = 1; i <= Number; i++)
                {
                    if (Number % i == 0)
                    {
                        if (isPrime(i) == true)
                        {
                            if (Number % (i * i) != 0)
                            {
                            Powerful = "The number is NOT Powerful!";
                                return false;
                            }

                        }
                    }
                }
            Powerful = "The number is Powerful!";
                return true;
            }
        
        //Test to see if the number is a planidrome
            public bool isPalindrome()
            {
                int number = Number;
                int remainder;
                int reverseNumber = 0;
                int tempNumber;

                tempNumber = number;
                while (number > 0)
                {
                    remainder = number % 10;
                    reverseNumber = reverseNumber * 10 + remainder;
                    number /= 10;
                }
                if (tempNumber == reverseNumber)
                {
                Plaindromic = "The number is Plaindromic";
                    return true;
                }
                else
                {
                Plaindromic = "The number is NOT Plaindromic";
                return false;
                }
            }
        }

}
