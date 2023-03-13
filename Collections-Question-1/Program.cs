using System.Collections;

namespace Collections_Question_1;
class Program
{
    static void Main(string[] args)
    {
        ArrayList primeNumbers = new ArrayList();
        ArrayList nonprimeNumbers = new ArrayList();
        int count = 0;
        for (int i = 1; i <= 20; i++)
        {
            try
            {
                Console.Write($"Please enter the {i}. positive number : ");
                int number = int.Parse(Console.ReadLine());
                if(number<0)
                {
                    Console.WriteLine("Number must be positive");
                    i--;
                }
                else
                {
                    for (int j = 1; j <= number; j++)
                    {
                        if(number%j == 0)
                            count++;
                    }
                        if(count == 2)
                            primeNumbers.Add(number);
                        else
                            nonprimeNumbers.Add(number);
                    
                    count = 0;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("The value entered is not a positive number.");
                i--;
            }
            
        }

        primeNumbers.Sort();
        primeNumbers.Reverse();

        nonprimeNumbers.Sort();
        nonprimeNumbers.Reverse();

        Console.WriteLine("*PRIME NUMBERS*");
        foreach (var number in primeNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("*NONPRIME NUMBERS*");
        foreach (var number in nonprimeNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("*TOTAL NUMBER OF ELEMENTS*");
        Console.WriteLine("Number of elements in a prime number array : " + primeNumbers.Count);
        Console.WriteLine("Number of elements in a nonprime number array : " + nonprimeNumbers.Count);

        Console.WriteLine("*AVARAGE OF THE ELEMENTS*");
        int sumPrime = 0;
        int sumNonprime = 0;
        foreach (var number in primeNumbers)
        {
            sumPrime += Convert.ToInt32(number);
        }
        Console.WriteLine("Average of prime numbers : " + (sumPrime/primeNumbers.Count));
        foreach (var number in nonprimeNumbers)
        {
            sumNonprime += Convert.ToInt32(number);
        }
        Console.WriteLine("Average of nonprime numbers : " + (sumNonprime/nonprimeNumbers.Count));

    }
}
