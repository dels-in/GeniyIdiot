using System;

namespace GeniyIdiotClassLibrary;

public static class UserResultStorage
{
    public static int GetNumber(string text)
    {
        while (true)
        {
            try
            {
                return Convert.ToInt32(text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введи число");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введи число от -2*10^9 до 2*10^9");
            }
        }
    }
}