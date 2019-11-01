using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Randoms
{
    public class RandomGenerator : IRandomGenerator
    {
        public static RandomGenerator Instance { get; } = new RandomGenerator();

        public int GetRandom(int minValue, int maxValue)
        {
            if (maxValue < minValue)
                throw new Exception("最大值不能小于最小值");

            //生成随机数种子
            var guid = Guid.NewGuid();
            var buffer = guid.ToByteArray();
            var seed = BitConverter.ToInt32(buffer, 0);

            Random random = new Random(seed);
            var value = random.Next(minValue,maxValue);
            return value;
        }

        public int GetRandom(int maxValue)
        {
            return GetRandom(0,maxValue);
        }

        public int GetRandom()
        {
            //生成随机数种子
            var guid = Guid.NewGuid();
            var buffer = guid.ToByteArray();
            var seed = BitConverter.ToInt32(buffer, 0);

            Random random = new Random(seed);
            var value = random.Next();
            return value;
        }
    }
}
