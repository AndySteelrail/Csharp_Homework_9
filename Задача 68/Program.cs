//Задача 68: Напишите программу вычисления
//функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

using System;

public class Program
{
    public static void Main()
    {
        int GetInput(string messageHello)
        {
            Console.WriteLine(messageHello);
            int number = int.Parse(Console.ReadLine()??"");
            return number;
        }
        
        int AkkermanFunction(int m, int n)
        {
            while (m != 0)
            {
                if (n == 0)
                {
                    n = 1;
                }
                else
                {
                    n = AkkermanFunction(m, n - 1);
                }
                m--;
            }
            return n + 1;
        }
        
        void GetOutput()
        {
            int m =
            GetInput(
                "Введите m - аргумент функции Аккермана:");
            int n =
            GetInput(
                "Введите n - аргумент функции Аккермана:");

            Console.WriteLine("Значение функции Аккермана для (m, n): " + 
            AkkermanFunction(m, n));
        }

        GetOutput();
    }
}