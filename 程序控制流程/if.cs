namespace ConsoleApp_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;double f = 0;
            Console.Write("请输入有固定工资收入的党员的月工资基数：");
            int salary=int.Parse(Console.ReadLine());
            if (salary > 0 && salary <= 3000) f = 0.5 / 100 * salary;
            else if (salary > 3000 && salary <= 5000) f = 1.0 / 100 * salary;
            else if (salary > 5000 && salary <= 10000) f = 1.5 / 100 * salary;
            else if (salary > 10000) f = 2.0 / 100 * salary;
            else Console.WriteLine("月工资基数输入有误!");
            Console.WriteLine("月工资基数={0}，交纳党费={1}",salary,f);
            Console.ReadKey();
        }
    }
}
