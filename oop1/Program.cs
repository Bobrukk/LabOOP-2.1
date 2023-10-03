using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Обчислення функції y=(√25-x^2) + 2a/x-3");
        Console.Write("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        if (x == 3)
        {
            Console.WriteLine("Ділення на (x - 3) неможливе.");
        }
        else if (x * x <= 25)
        {
            double y = Math.Sqrt(25 - x * x) + (2 * a / (x - 3));
            Console.WriteLine($"Значення функції y = {y}");
        }
        else
        {
            Console.WriteLine("Корінь з від'ємного числа неможливо обчислити.");
        }

        Console.WriteLine("\n2. Пошук чисел-паліндромів:");

        for (int number = 1; number <= 100; number++)
        {
            if (IsPalindrome(number) && IsPalindrome(number * number))
            {
                Console.WriteLine($"{number} ({number * number})");
            }
        }

        Console.WriteLine("\n3. Заміна символів у рядку:");

        Console.Write("Введіть рядок: ");
        string input = Console.ReadLine();

        Console.Write("Введіть позицію для заміни (починаючи з 0): ");
        int position = Convert.ToInt32(Console.ReadLine());

        string result = ReplaceZerosAndOnes(input, position);
        Console.WriteLine($"Результат: {result}");
    }

    static bool IsPalindrome(int number)
    {
        string numStr = number.ToString();
        int len = numStr.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (numStr[i] != numStr[len - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    static string ReplaceZerosAndOnes(string input, int position)
    {
        if (position < 0 || position >= input.Length)
        {
            Console.WriteLine("Позиція для заміни знаходиться за межами рядка.");
            return input;
        }

        char[] charArray = input.ToCharArray();
        char targetChar = charArray[position];

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] == '0')
            {
                charArray[i] = '1';
            }
            else if (charArray[i] == '1')
            {
                charArray[i] = '0';
            }
        }

        charArray[position] = targetChar;
        return new string(charArray);
    }
}
