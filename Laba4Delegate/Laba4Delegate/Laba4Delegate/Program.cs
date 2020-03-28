using System;

namespace Laba4Delegate
{
    class Program
    {
        private delegate double MyDelegate(double x);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDelegate[] del = new MyDelegate[10];
            Random rnd = new Random();
            Methods meth = new Methods();
            for(int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt32(rnd.Next(1, 5));
                switch (a)
                {
                    case 1:
                        del[i] = meth.Add;
                        break;
                    case 2:
                        del[i] = meth.Multiply;
                        break;
                    case 3:
                        del[i] = meth.Division;
                        break;
                    case 4:
                        del[i] = meth.Subtraction;
                        break;
                    case 5:
                        del[i] = meth.Pow;
                        break;

                }
            }
            double num;
            Console.WriteLine("Введите число, над которым хотите проделать операции");
            num = double.Parse(Console.ReadLine());
            for(int j = 0; j < 10; j++)
            {
                num = del[j](num);

            }
            
        }
    }
}
