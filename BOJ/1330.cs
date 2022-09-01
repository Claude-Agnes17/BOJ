using System.Text;

namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            
            if(int.Parse(num[0]) > int.Parse(num[1]))
            {
                Console.WriteLine(">");
            }
            else if (int.Parse(num[0]) < int.Parse(num[1]))
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}