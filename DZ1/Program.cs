using System;
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
namespace DZ1
{
    class Program
    {
        static int[] vvodMas(int size)
        {
            Console.WriteLine("Введите числа через пробел и нажмите Enter: ");
            string[] massiv =Console.ReadLine().Split();
            int[] massivInt = new int[size];
            for (int i =0;i<massiv.Length;i++)
            {
                massivInt[i]=int.Parse(massiv[i]);
            }
            return massivInt; 
        }
        static int countMas(int[] mass)
        {
            int count = 0;
            for (int i =0;i<mass.Length;i++)
            {
                if (mass[i]>0)
                {
                    count++;
                }
            }
            return count;
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Какое число элементов вы хотите ввести? ");
            int size = int.Parse(Console.ReadLine()); 
            int[] mass = vvodMas(size);
            Console.Write("Полученный массив [  ");
            for (int i =0; i<mass.Length; i++)
            {
                Console.Write(mass[i]+"  ");
            }
            Console.WriteLine("]"); 
            int count = countMas(mass);
            Console.WriteLine(" ");
            Console.WriteLine("Колличество неотрицательных значений: "+count);
        }
    }
}
