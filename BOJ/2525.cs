using System.Text;

namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            int minutes = int.Parse(Console.ReadLine());

            int h = int.Parse(a[0]);
            int m = int.Parse(a[1]);

            int end_h = h;
            int end_m = m + minutes;

            if (end_m > 59)
            {
                end_h += end_m / 60;
                end_m %= 60;
            }

            end_h %= 24;

            Console.WriteLine(end_h + " " + end_m);
        }
    }
}