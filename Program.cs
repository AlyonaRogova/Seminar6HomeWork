using System;

namespace Seminar7HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            
            int Positive (int size){
                int[] array = new int[size];
                for(int i = 0;i<size;i++)
                {
                    Console.WriteLine("Введите {0}-й элемент", i + 1);
                    array[i] = int.Parse(Console.ReadLine());
                }
                int res=0;
                    for (int i=0; i<array.Length; i++){
                        if (array[i]>0) res++;
                    }
                return res;
            }

            
            Console.WriteLine ("Введите количество элементов: ");
            int size = Convert.ToInt32(Console.ReadLine());
                        
            int result = Positive (size);
            Console.WriteLine ($"Чисел больше нуля: {result} ");

            // Напишите программу, которая найдёт точку пересечения двух прямых, 
            //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

            // void SearchM (double b1, double k1, double b2, double k2){
            //     double x = (b2-b1)/(k1-k2);
            //     double y = k1 * x + b1;
            //     bool point = false;
            //     if (k1*x+b1 == k2*x+b2) {
            //         point = true;
            //     }
            // if (point == true) Console.WriteLine("Прямые пересекаются в точке ["+x+" , "+y+"]");
            // else Console.WriteLine ("Прямые не пересекаются");
            // }

            // Console.WriteLine("Введите координаты b1 и k1: ");
            // double b1=Convert.ToDouble(Console.ReadLine());
            // double k1=Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Введите координаты b2 и k2: ");
            // double b2=Convert.ToDouble(Console.ReadLine());
            // double k2=Convert.ToDouble(Console.ReadLine());
            
            
            // SearchM (b1,k1,b2,k2);
        }
    }
}
