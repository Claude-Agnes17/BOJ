using System.Text;

namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int t = int.Parse(num);

            for(int i = 0; i < t; i++)
            {
                string[] str = Console.ReadLine().Split();

                Console.WriteLine(int.Parse(str[0]) + int.Parse(str[1]));
            }
        }
    }
}