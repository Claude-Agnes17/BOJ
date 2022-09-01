using System.Text;

namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();

            int h = int.Parse(a[0]);
            int m = int.Parse(a[1]);

            if(m < 45)
            {
                if (h == 0) h = 23;
                else h--;

                m = (m + 60) - 45;
            }
            else
            {
                m -= 45;
            }
            Console.WriteLine(h + " " + m);
        }
    }
}