using System;

public class Class1
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetMinX(5, 2, 1));
    }
    private static string GetMinX(int a, int b, int c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    return 0.ToString();
                }
                else
                {
                    if (b < c)
                    {
                        return b.ToString();
                    }
                    else
                    {
                        return c.ToString();
                    }
                }
            }
            else if (c == 0)
            {
                return "Impossible";
            }
            else
            {
                return "Impossible";
            }
        }
        else
        {
            return ((-b) / 2 * a).ToString();
        }
    }
}
