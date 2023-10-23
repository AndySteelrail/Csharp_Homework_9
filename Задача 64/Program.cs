// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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
        
        void GetAllNaturalNumbers(int number)
        {
            if (number > 1)
            {
                Console.Write($"{number}, ");
                GetAllNaturalNumbers(number - 1);
            } else {
                Console.Write("1");
            }
        }
        
        GetAllNaturalNumbers(
            GetInput(
                "Введите N, для которого будут " +
                "выведены все натуральные числа, " +
                "меньшие, либо равные N:")
        );
    }
}