// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
        
        int GetNaturalNumbersSum(int m, int n)
        {
            if (m == n)
            {
                return m;
            }
            else
            {
                return m + GetNaturalNumbersSum(m + 1, n);
            }
        }
        
        void GetOutput()
        {
            int m =
            GetInput(
                "Введите M, с которого будем считать сумму натуральных чисел:");
            int n =
            GetInput(
                "Введите N, до которого будем считать сумму натуральных чисел:");
        
            if (m > n)
            {
                int temp = m;
                m = n;
                n = temp;
            }

            Console.WriteLine("Сумма натуральных чисел от M до N: " + 
            GetNaturalNumbersSum(m, n));
        }

        GetOutput();
    }
}