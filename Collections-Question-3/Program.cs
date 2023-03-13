namespace Collections_Question_3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a sentence : ");
        string sentence = Console.ReadLine();
        char[] arrayChar = sentence.ToCharArray();
        List<char> vowels = new List<char>();

        foreach (var letter in arrayChar)
        {
            if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u'|| letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                vowels.Add(letter);
            }
        }
        Console.WriteLine("*VOWELS IN SENTENCE*");
        foreach (var item in vowels)
        {
            Console.WriteLine(item);
        }
    }
}
