namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int a = 0;
            for(int i = 0; i <num.Length; i++)
            {
                a += int.Parse(num[i]) * int.Parse(num[i]);
            }
            int result = a % 10;
            Console.WriteLine(result);
        }
    }
}