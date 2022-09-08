using System.Text;

namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);

            if (a >= b)
            {
                if (a >= c)
                {
                    if (b >= c)
                    {
                        Console.WriteLine(b);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                if (b >= c)
                {
                    if (a >= c)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}