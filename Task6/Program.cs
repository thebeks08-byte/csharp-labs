using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Кириллица мен қазақ әріптері дұрыс шығуы үшін
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        string text;
        do
        {
            Console.Write("Жолды енгізіңіз: ");
            text = Console.ReadLine();
        } while (string.IsNullOrEmpty(text));

        Console.WriteLine("Бастапқы жол: [" + text + "]");
    }
}
