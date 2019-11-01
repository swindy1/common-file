using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Smile.Guids
{
    /// <summary>
    /// Guid生成
    /// </summary>
    public interface IGuidGenerator
    {
        /// <summary>
        /// 创建Guid
        /// </summary>
        /// <returns></returns>
        Guid Create();
    }
}
