using System;

namespace DZ2
{  
    class Program
    {   
         static double vvod()
         {
            var variable = double.Parse(Console.ReadLine());
            return variable;  
        }
        static double[] count(double b1, double b2, double k1, double k2)
        {
            double[] mass = new double[2];
            mass[0]= -(b1-b2)/(k1-k2);
            mass[1]=k1*mass[0]+b1;
            return mass;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите b1: ");
            double b1 = vvod(); 
            Console.WriteLine("Введите b2: ");
            double b2 = vvod(); 
            Console.WriteLine("Введите k1: ");
            double k1 = vvod(); 
            Console.WriteLine("Введите k2: ");
            double k2 = vvod(); 
    
            Console.WriteLine(" ");
            Console.WriteLine("Прямые имеют вид:");
            Console.WriteLine("y1 = "+k1+"*x + "+b1);
            Console.WriteLine("y2 = "+k2+"*x + "+b2);
            Console.WriteLine(" ");
    
            double[] mass = count(b1,b2,k1,k2);
            Console.WriteLine("Пересечение двух прямых происходит в точке с координатами: ");
            Console.WriteLine("X: "+mass[0]);
            Console.WriteLine("Y: "+mass[1]);
        }
    }
}
