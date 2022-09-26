using System;

namespace Seminar7HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            
            // double [] CreateArray (double size){
            //     double [] array = new double [size];
            //         for (double i=0; i<size; i++){
            //             array[i] = Convert.ToDouble(Console.ReadLine());
            //         }
            //     return array;
            // }

            // void ShowArray (double[] array){
            //     for (double i = 0; i<array.Length; i++){
            //         Console.Write($"{array[i]} ");
            //     }
            // }

            // double Positive (double [] array){
            //     double res=0;
            //     for (double i=0; i<array.Length; i++){
            //         if (array[i]>0) res+=1;
            //     }
            //     return res;
            // }

            // // Console.WriteLine("Введите ряд чисел через запятую: ");
            // Console.WriteLine ("Введите количество элементов: ");
            // double size = Convert.ToDouble(Console.ReadLine());
                        
            // double [] array = CreateArray(size);
            // ShowArray (array);
            
            // double result = Positive (array);
            // Console.WriteLine ($"Чисел больше нуля: {result} ");

            // Напишите программу, которая найдёт точку пересечения двух прямых, 
            //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

            // double SearchX (double b1, double k1, double b2, double k2){
            //     double x;
            //     x = (b2-b1)/(k1-k2);
            //     return x;
            // }

            void SearchM (double b1, double k1, double b2, double k2){
                double x = (b2-b1)/(k1-k2);
                double y = k1 * x + b1;
                bool point = false;
                if (k1*x+b1 == k2*x+b2) {
                    point = true;
                }
            if (point == true) Console.WriteLine("Прямые пересекаются в точке ["+x+" , "+y+"]");
            else Console.WriteLine ("Прямые не пересекаются");
            }

            Console.WriteLine("Введите координаты b1 и k1: ");
            double b1=Convert.ToDouble(Console.ReadLine());
            double k1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты b2 и k2: ");
            double b2=Convert.ToDouble(Console.ReadLine());
            double k2=Convert.ToDouble(Console.ReadLine());
            
            
            SearchM (b1,k1,b2,k2);
        }
    }
}
