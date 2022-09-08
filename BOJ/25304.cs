using System.Text;

namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for(int i=0; i < n; i++)
            {
                string[] y = Console.ReadLine().Split();

                sum += (int.Parse(y[0]) * int.Parse(y[1]));
            }
            if(x == sum)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}