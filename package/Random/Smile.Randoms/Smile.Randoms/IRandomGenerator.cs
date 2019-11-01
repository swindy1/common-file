using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Randoms
{
    /// <summary>
    /// 随机数生成器
    /// </summary>
    public interface IRandomGenerator
    {
        int GetRandom(int minValue,int maxValue);

        int GetRandom(int maxValue);

        int GetRandom();
    }
}
