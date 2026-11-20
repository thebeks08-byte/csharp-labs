using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        string text;
        do
        {
            Console.Write("Жолды енгізіңіз: ");
            text = Console.ReadLine();
        } while (string.IsNullOrEmpty(text));

        string withoutDigits = RemoveDigits(text);
        int digitCount = CountDigits(text);

        Console.WriteLine("Бастапқы жол: [" + text + "]");
        Console.WriteLine("Цифрсыз жол:  [" + withoutDigits + "]");
        Console.WriteLine("Алынған цифрлар саны = " + digitCount);
    }

    // Цифрлардан басқа символдарды жаңа жолға бір-бірлеп қосады
    static string RemoveDigits(string text)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (!char.IsDigit(ch))
                result += ch;
        }
        return result;
    }

    // Жолдағы цифрлардың санын есептейді
    static int CountDigits(string text)
    {
        int count = 0;
        for (int i = 0; i < text.Length; i++)
            if (char.IsDigit(text[i]))
                count++;
        return count;
    }
}
