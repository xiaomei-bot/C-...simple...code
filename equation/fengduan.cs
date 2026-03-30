namespace Consolefenduanhanshu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("请输入x：");
            String s = Console.ReadLine();
            x = double.Parse(s);

            // 方法一：利用“一句单分支语句”实现
            y = (x * x - 3 * x) / (x * x + 1) + 2 * Math.PI + Math.Sin(x);
            if (x < 0)
                y = Math.Log(-5 * x ) + 6 * Math.Sqrt(Math.Abs(x) + Math.Pow(Math.E, 4)) - Math.Pow(x + 1, 3);
            Console.WriteLine("方法一：x = {0}, y = {1}", x, y);

            // 方法二：利用“两句单分支语句”实现
            if (x >= 0)
                y = (x * x - 3 * x) / (x * x + 1) + 2 * Math.PI + Math.Sin(x);
            if (x < 0)
                y = Math.Log(-5 * x) + 6 * Math.Sqrt(Math.Abs(x) + Math.Pow(Math.E, 4)) - Math.Pow(x + 1, 3);
            Console.WriteLine("方法二：x = {0}, y = {1}", x, y);

            // 方法三：利用“双分支结构”实现
            if (x >= 0)
                y = (x * x - 3 * x) / (x * x + 1) + 2 * Math.PI + Math.Sin(x);
            else
                y = Math.Log(-5 * x ) + 6 * Math.Sqrt(Math.Abs(x) + Math.Pow(Math.E, 4)) - Math.Pow(x + 1, 3);
            Console.WriteLine("方法三：x = {0}, y = {1}", x, y);

            // 方法四：利用“条件运算符”实现
            y = x >= 0 ? (x * x - 3 * x) / (x * x + 1) + 2 * Math.PI + Math.Sin(x) : Math.Log(-5 * x ) + 6 * Math.Sqrt(Math.Abs(x) + Math.Pow(Math.E, 4)) - Math.Pow(x + 1, 3);
            Console.WriteLine("方法四：x = {0}, y = {1}", x, y);

            Console.ReadKey();
        }
    }
}
