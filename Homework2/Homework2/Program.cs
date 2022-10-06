using System;

namespace Homework2
{
    class Program
    {
        static double s1(double x)
        {
            double y = 3;
            return y;
        }

        static double s2(double x, double r)
        {
            double a = 3;
            double y;
            y = Math.Sqrt(r * r - x * x) - a;
            return -y;
        }


        static double s3(double x)
        {
            double y;
            double a = -2;
            double b = 9;
            y = a * x + b;
            return y;
        }


        static double s4(double x)
        {
            double a = 9;
            double y;
            y = x - a;
            return y;
        }

        static void Main()
        {
            string r1;
            
            Console.WriteLine("Радиус =");
            r1 = Console.ReadLine();
            
            double r = Convert.ToDouble(r1);
            for (double x = -7; x <= 11; x += 0.2)
            {

                if (x < -7)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if (x <= -3)
                {

                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, s1(x));
                }
                else if (x < 3)
                {
                    if (r < 3)
                    {
                        if (Math.Abs(x) > Math.Abs(r))
                        {
                            Console.WriteLine("Функция не определена ", x);
                        }
                        else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, s2(x, r));
                        }
                    }
                }
                else if (x < 6)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, s3(x));
                }
                else if (x < 11)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, s4(x));
                }
                else
                {
                    Console.WriteLine("Функция не определена");
                }

}

        }
    }
}
