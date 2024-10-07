class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Method Examples:");
        Program.FavoriteLyrics();
        Console.WriteLine("Remainder of random number divided by 2 is " + RandomRemainder() + ".");
        Console.Write("Give me two numbers to multiply: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Product of " + num1 + " and " + num2 + " is: " + Multiply(num1, num2));
        Console.Write("What's your name?: ");
        string name = Console.ReadLine();
        Console.Write("What's your surname?: ");
        string surname = Console.ReadLine();
        Greet(name, surname);
    }

    // prints favorite lyrics
    static void FavoriteLyrics()
    {
        Console.WriteLine("My favorite lyrics are from the band Lamb of God:");
        Console.WriteLine("Now you've got something to die for!");
    }

    // returns remainder from a random generated number divided by 2 
    static int RandomRemainder()
    {
        Random random = new Random();
        int number = random.Next(0, 100);
        return number % 2;
    }

    // takes two parameters and returns their product
    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // takes two parameters and prints them
    static void Greet(string name, string surname)
    {
        Console.WriteLine("Welcome " + name + " " + surname);
    }
}