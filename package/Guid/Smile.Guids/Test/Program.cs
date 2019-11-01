using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Smile.Guids.SequentialGuidGenerator.Instance.Create();
            Console.WriteLine(id);
        }
    }
}
