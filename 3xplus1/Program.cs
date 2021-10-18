using System;

namespace _3xplus1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number between 2 and Infinity");
            int userinput;
            userinput = Convert.ToInt32(Console.ReadLine());

            userinput = userinput * 3;
            userinput++;
            Convert.ToString(userinput);
            Console.WriteLine(userinput);
            Convert.ToInt32(userinput);
            while (userinput >= 1)
            {
                if (userinput % 2 == 0)
                {
                    userinput = userinput / 2;
                    Convert.ToString(userinput);
                    Console.WriteLine(userinput);
                    Convert.ToInt32(userinput);
                }
                else
                {
                    userinput = userinput * 3;
                    userinput++;
                    Convert.ToString(userinput);
                    Console.WriteLine(userinput);
                    Convert.ToInt32(userinput);
                }
                if (userinput == 4 || userinput == 1)
                {
                    break;
                }
            }
        }
    }
}
