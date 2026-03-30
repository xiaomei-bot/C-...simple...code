namespace Consolefangcheng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2, realPart, imagPart;
            Console.Write("请输入系数a: ");
            String s = Console.ReadLine();
            a = double.Parse(s);
            Console.Write("请输入系数b: ");
            s = Console.ReadLine();
            b = double.Parse(s);
            Console.Write("请输入系数c: ");
            s = Console.ReadLine();
            c = double.Parse(s);

            if (a == 0)
            {
                if (b == 0) Console.WriteLine("此方程无解!");
                else Console.WriteLine("此方程的解为: {0}", -c / b);
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("此方程有两个不等实根, {0} 和 {1}", x1, x2);
                }
                else
                {
                    if (delta == 0) Console.WriteLine("此方程有两个相等实根, {0}", -b / (2 * a));
                    else
                    {
                        realPart = -b / (2 * a);
                        imagPart = Math.Sqrt(-delta) / (2 * a);
                        Console.WriteLine("此方程有两个共轭复根, {0}+{1}i 和 {0}-{1}i", realPart, imagPart);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
