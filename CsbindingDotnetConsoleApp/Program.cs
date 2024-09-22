namespace CsbindingDotnetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcPoint(10000000);
        }

        static void CalcPoint(int points)
        {
            var src = new byte[points * 3];
            var index = 0;

            for (var i = 0; i < points; i++)
            {
                src[index++] = 1;
                src[index++] = 2;
                src[index++] = 3;
            }

            foreach (var i in Enumerable.Range(0, 9))
            {
                Console.WriteLine(src[i]);
            }
        }
    }
}
