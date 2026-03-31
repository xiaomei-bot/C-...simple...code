namespace ConsoleApp_IsPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, k, i, num = 0;
            //方法一：利用for循环和break语句
            Console.WriteLine("方法一：1~100的所有素数为：");
            for(m=2;m<=100;m++)
            {
                k = (int)(Math.Sqrt(m));
                for(i=2;i<=k;i++)
                {
                    if (m % i == 0) break;
                }
                if(i==k+1)
                {
                    Console.Write("{0,5}", m);
                    num++;
                    if (num % 10 == 0) Console.WriteLine();
                }
            }
            //方法二：利用while循环和Boolean变量
            Console.WriteLine("\n方法二：1~100的所有素数为：");
            num = 0;
            for(m=2;m<=100;m++)
            {
                bool flag = true;
                k=(int)(Math.Sqrt(m));
                i = 2;
                while(i<=k&&flag==true)
                {
                    if (m % i == 0) flag = false;
                    else i++;
                }
                if(flag==true)
                {
                    Console.Write("{0,5}", m);
                    num++;
                    if(num%10==0) Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
