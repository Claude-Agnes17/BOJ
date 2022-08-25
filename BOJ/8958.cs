namespace Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] Case = new string[n];
            for(int i = 0; i < n; i++)
            {
                Case[i] = Console.ReadLine();
            }

            for(int i = 0; i < n; i++)
            {
                char[] temp = Case[i].ToCharArray();
                int j = 0;
                int resultScore = 0;
                int score = 0;

                while (true)
                {
                    if(temp[j].ToString() == "O")
                    {
                        score++;
                        resultScore += score;
                    }
                    else
                    {
                        score = 0;
                    }
                    j++;
                    if (j == temp.Length) break;
                }
                Console.WriteLine(resultScore);
            }
        }
    }
}