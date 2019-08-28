using System;

namespace PrimeIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumbers pm = new PrimeNumbers();
            foreach (int num in pm.PrimeTo(1000))
            {
                Console.WriteLine(num);
            }

            // Wait for user to acknowledge the results
            Console.WriteLine("Press any key to terminate...");
            Console.Read();
        }

            class PrimeNumbers
            {
                public System.Collections.IEnumerable PrimeTo(int maximum)
                {
                yield return 1;
                for (int i = 2; i < maximum; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        yield return i;
                    }
                }
                }
            }
        
    }
}
