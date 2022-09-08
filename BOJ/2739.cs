using System.Text;

namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int a = int.Parse(num);

            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
        }
    }
}