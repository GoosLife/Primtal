namespace Primtal;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int maxNumber;
        bool isPrime;

        // Get numbers to iterate
        do
        {
            input = Console.ReadLine();
        } while (!int.TryParse(input, out maxNumber));

        for (int i = 0; i < maxNumber; i++)
        {
            isPrime = true; // The number is assumed to be a prime number until otherwise proven.

            // Check if i can be equally divided by any number that's not 1 or itself.
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0 && (i != 1 && i != 0)) // If division by any number other than itself returns a whole number, it is not a prime
                                                      // except in the case of 1 and 0, which are not considered primes.
                {
                    isPrime = false;
                }
            }

            if (isPrime) // Print prime numbers in red.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
            }
            else // Print non-prime numbers in gray.
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(i);
            }
        }
    }
}