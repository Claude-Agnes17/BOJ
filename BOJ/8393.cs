using System.Text;

namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int n = int.Parse(num);

            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}