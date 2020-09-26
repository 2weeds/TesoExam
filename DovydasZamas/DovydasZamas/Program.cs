using System;
using System.Security.Cryptography;

namespace DovydasZamas
{
    class Program
    {
        public static double SolveQuadratic(double a, double b, double c)

        {

            double sqrtpart = b * b - 4 * a * c;

            double x, x1, x2, img;

            if (sqrtpart > 0)
            {
                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                if (x1>0)
                {
                    return x1;
                }
                if (x2 > 0)
                {
                    return x2;
                }
                else return -1;
            }
            else if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                x = -b / (2 * a);
                img = System.Math.Sqrt(sqrtpart) / (2 * a);
                return -1;
            }

            else
            {
                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                if (x > 0)
                {
                    return x;
                }
                else return -1;
            }
        }



        static int eggDrop(int eggCount, int x, int answer, int floorCount)
        {
            int tmp = x;
            while (eggCount != 0)
            {
                if (tmp<floorCount&&tmp>answer)
                {
                    eggCount--;
                    if (eggCount>0)
                    {
                        tmp = tmp - x;
                    }
                    if (eggCount==0)
                    {
                        return tmp;
                    }
                }
                else
                {
                    x = x - 1;
                    Console.WriteLine("Metamas kiausinis is"+" "+tmp+" "+"auksto");
                    tmp = tmp + x;
                }
            }
            tmp = tmp - x;
            return tmp;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Iveskite aukstu kieki:");
            int floorCount = int.Parse(Console.ReadLine());
            int answer = rnd.Next(1, floorCount);
            Console.WriteLine("Tikrasis atsakymas yra:"+answer);
            double dx = SolveQuadratic(1, 1, floorCount * -2);
            int x = (int)Math.Ceiling(dx);
            int eggCount = 2;
            Console.WriteLine("Gautas atsakymas:"+eggDrop(eggCount,x,answer,floorCount)); 
            Console.ReadKey();
        }

    }
}
