namespace Collections_Question_2;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[20];
        int[] biggestNumbers = new int[3];
        int[] lowestNumbers = new int[3];
        for (int i = 0; i < 20; i++)
        {
            try
            {
                Console.Write($"Please enter the {i+1}. positive number : ");
                int number = int.Parse(Console.ReadLine());
                if(number<0)
                {
                    Console.WriteLine("Number must be positive");
                    i--;
                }
                else
                {
                    numbers[i] = number;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("The value entered is not a positive number.");
                i--;
            }
            
        }
        
        Array.Sort(numbers);

        for(int i = 0; i<3; i++)
        {
            lowestNumbers[i] = numbers[i];
        }
        for (int i = 0; i < 3; i++)
        {
            biggestNumbers[i] = numbers[19-i];
        }
        int a1 = biggestNumbers.Sum()/3;
        int a2 = lowestNumbers.Sum()/3;
        Console.WriteLine("Average of the 3 biggest numbers in the array : " + a1);
        Console.WriteLine("Average of the 3 lowest numbers in the array : " + a2);
        Console.WriteLine("The sum of the averages : " + (a1+a2));
    }
}
