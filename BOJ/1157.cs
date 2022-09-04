using System.Text;

namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            int[] intArray = new int[91];

            for(int i=0; i<input.Length; i++)
            {
                intArray[input[i]]++;
            }

            int max = 0;

            char c = '?';

            for(int i = 'A'; i<= 'Z'; i++)
            {
                if (intArray[i] > max)
                {
                    max = intArray[i];
                    c = (char)i;
                }
                else if(intArray[i] == max)
                {
                    c = '?';
                }
            }
            Console.Write(c);
        }
    }
}