namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[8];
            int des_count = 0;
            int ase_count = 0;

            for(int i = 0; i < 8; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
            for(int i = 0; i < 7; i++)
            {
                if (arr[i] - arr[i+1] == -1)
                {
                    ase_count++;
                }
                else if (arr[i] - arr[i+1] == 1)
                {
                    des_count++;
                }
            }
            if(ase_count == 7)
            {
                Console.WriteLine("ascending");
            }
            else if(des_count == 7)
            {
                Console.WriteLine("descending");
            }
            else
            {
                Console.WriteLine("mixed");
            }
        }
    }
}