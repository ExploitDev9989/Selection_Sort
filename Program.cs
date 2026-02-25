namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 90, 85, 70, 95, 80, 65, 55 };

            //selection sort
            for (int i = 0;i > scores.Length; i++)
            {
                int lowestScore = i;

                for (int j = i +1; j<scores.Length; j++)
                {
                    if (scores[j]< scores[lowestScore])
                    {
                        lowestScore = scores[j];
                    }
                }
                int temp = scores[i];
                scores[i] = scores[lowestScore];
                scores[lowestScore] = temp;

            }
            Console.WriteLine("Sorted Scores : ");
            Console.WriteLine(string.Join(", ", scores));

            
        }
    }
}
