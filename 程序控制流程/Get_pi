namespace ConsoleApp_Get_pi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n, t, pi;
            int s;
            pi = 0;t = 1;n = 1;s = 1;
            while(Math.Abs(t)>=Math.Pow(10,-6))
            {
                pi += t;
                n += 2;
                s = -s;
                t = s / n;
            }
            pi *= 4;
            Console.WriteLine("pi={0}",pi);
            Console.ReadKey();
        }
    }
}
