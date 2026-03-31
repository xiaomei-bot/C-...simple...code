namespace ConsoleApp_if_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c; double f = 0;
            Console.Write("请输入有固定工资收入的党员的月工资基数:");
            int salary = int.Parse(Console.ReadLine());
            if (salary > 10000) c = 11;
            else c = (int)Math.Ceiling(salary / 1000.0);
            switch (c)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    f = 0.5 / 100 * salary;break;
                case 4:
                case 5:
                    f = 1.0 / 100 * salary; break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    f = 1.5 / 100 * salary; break;
                case 11:
                    f = 2.0 / 100 * salary; break;

            }
            Console.WriteLine("月工资基数={0}，交纳党费={1}",salary,f);
            Console.ReadKey();
        }
    }
}
