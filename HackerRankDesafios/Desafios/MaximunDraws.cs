using System.Collections.Generic;
public class MaximunDraws
{
    public static void Run()
    {
          TextWriter textWriter = Console.Out;

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = MaximunDraws.maximumDraws(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();


    }

    public static int maximumDraws(int n)
    {
        return 0;
    }
}