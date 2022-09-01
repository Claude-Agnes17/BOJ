using System.Text;

namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] a = Console.ReadLine().Split('-');
            foreach (string s in a)
            {
                sb.Append(s[0].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}