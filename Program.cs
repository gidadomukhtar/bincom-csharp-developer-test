class Program
{
    static void Main(string[] args)
    {
        // Task 1: Declare and initialize variables

        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Is Admin: {isAdmin}");


        // Task 2: Check if a number is even or odd

        Console.Write("\nEnter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }


        // Task 3: Print numbers 1 to 10

        Console.WriteLine("\nNumbers 1 to 10:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }


        // Task 4: Array and foreach loop

        int[] numbers = { 2, 4, 6, 8, 10 };

        int sum = 0;

        foreach (int numberInArray in numbers)
        {
            sum += numberInArray;
        }

        Console.WriteLine($"\nSum: {sum}");

        Console.WriteLine("Array elements:");

        foreach (int numberInArray in numbers)
        {
            Console.WriteLine(numberInArray);
        }


        // Task 5: Call the Greet method

        Greet("Alice");
    }


    static void Greet(string name)
    {
        Console.WriteLine($"\nHello, {name}!");
    }
}
