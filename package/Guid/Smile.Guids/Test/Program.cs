using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Smile.Guids.SequentialGuid.Instance.Create();
            Console.WriteLine(id);
        }
    }
}
