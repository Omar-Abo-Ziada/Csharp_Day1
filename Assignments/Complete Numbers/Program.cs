namespace Complete_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.Write a program to show the complete numbers in range[1, 1000].
            // Note: A complete number is the one which sum of its factors equals the same number
            // (e.g. 6 = 1 + 2 + 3)

            for(int i = 1; i <= 1000; i++)
            {
                int sumOfFactors = 0;

                for (int j = 1; j < i; j++)
                {
                    if( i % j == 0 )
                    {
                        sumOfFactors += j;
                    }
                }
                if(sumOfFactors == i )
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}