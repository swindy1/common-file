using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = Smile.Randoms.RandomGenerator.Instance.GetRandom(0, 100);
            var value2 = Smile.Randoms.RandomGenerator.Instance.GetRandom(0, 100);

            var value3 = Smile.Randoms.RandomGenerator.Instance.GetRandom(100);
            var value4 = Smile.Randoms.RandomGenerator.Instance.GetRandom(100);

            var value5 = Smile.Randoms.RandomGenerator.Instance.GetRandom();
            var value6 = Smile.Randoms.RandomGenerator.Instance.GetRandom();

            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine(value3);
            Console.WriteLine(value4);

            Console.WriteLine(value5);
            Console.WriteLine(value6);
        }
    }
}
