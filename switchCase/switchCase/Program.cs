using System;

class Program
{
    static void Main(String[] args)
    {
        
        Console.WriteLine("Enter the first letter of your mobile brand:");
        char input;
        input = Console.ReadKey().KeyChar;
        Console.WriteLine();  
        input = char.ToLower(input);

        
        switch (input)
        {
            case 'o':
                Console.WriteLine("One Plus");
                break;
            case 's':
                Console.WriteLine("Samsung");
                break;
            case 'r':
                Console.WriteLine("Realme");
                break;
            case 'v':
                Console.WriteLine("Vivo");
                break;
            case 'i':
                Console.WriteLine("Infinix");
                break;
            default:
                Console.WriteLine("Unknown brand");
                break;
        }

        Console.ReadKey();
    }
}