using System;

namespace ClassPoStepeniAvtomatistia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            per: Console.Write("Для выбора операции нажмите \n 1)Сложение '+' \n 2)Вычитание '-'\n 3)Умножение '*' \n 4)Деление '/' \n 5)Возведение в степень '^'\n 6)Выход - 1\n");
            Console.Write("Введите операцию которую хотите выполнить: ");
            string simvol=Console.ReadLine();
            switch (simvol)
            {
                case "+":
                    {
                        try
                        {
                            Console.WriteLine("Введите первое число сложения: ");
                        double a=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число сложения: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0}+{1}={2}", a, b, program.Summ(a, b));
                            goto per;
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка");
                            goto per;
                        }
                    }
                    break;
                case "-":
                    {
                        try
                        {
                            Console.WriteLine("Введите первое число: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0}-{1}={2}", a, b, program.Razn(a, b));
                            goto per;
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка");
                            goto per;
                        }
                    }
                    break;
                case "*":
                    {
                        try
                        {
                            Console.WriteLine("Введите первое число: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0}*{1}={2}", a, b, program.Ymnog(a, b));
                            goto per;
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка");
                            goto per;
                        }
                    }
                    break;
                case "/":
                    {
                        try
                        {
                            Console.WriteLine("Введите первое число: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0}/{1}={2}", a, b, program.Delen(a, b));
                            goto per;
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка");
                            goto per;
                        }
                    }
                    break;
                case "^":
                    {
                        try
                        {
                            Console.WriteLine("Введите число: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите степень: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0}^{1}={2}", a, b, program.POW(a, b));
                            goto per;
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка");
                            goto per;
                        }
                    }
                    break;
                case "1":
                    {
                        Console.WriteLine("До свидание");
                    }
                    break;
                default:
                    Console.WriteLine("Данного варианта нет");
                    goto per;
                    break;

            }

            
        }

        public double Summ(double x,double y)
        {
            return x + y;
        }

        public double Razn(double x, double y)
        {
            return x - y;
        }

        public double Ymnog(double x, double y)
        {
            return x * y;
        }

        public double Delen(double x, double y)
        {
            return x / y;
        }

        public double POW(double x, double y)
        {
            return Math.Pow(x,y);
        }
    }
}
