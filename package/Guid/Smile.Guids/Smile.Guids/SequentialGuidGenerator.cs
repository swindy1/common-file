using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Smile.Guids
{
    /// <summary>
    /// 有序Guid
    /// </summary>
    public class SequentialGuidGenerator : IGuidGenerator
    {
        private SequentialGuidGenerator() { }

        public static SequentialGuidGenerator Instance { get; } = new SequentialGuidGenerator();

        public virtual Guid Create()
        {
            //生成8字节随机数
            var rcp = new RNGCryptoServiceProvider();
            var randomBytes = new Byte[8];
            rcp.GetBytes(randomBytes);
            Console.WriteLine(BitConverter.ToString(randomBytes));

            //生成长度为16的随机字符串
            var randomStr = BitConverter.ToString(randomBytes).Replace("-", "").ToLower();
            randomStr = "-" + randomStr.Substring(0, 4) + "-" + randomStr.Substring(4, 12);

            //精确到微秒
            var timeStr = DateTime.Now.ToString("yyMMddHH-mmffffff");
            var idStr = timeStr.Substring(0, 13) + "-" + timeStr.Substring(13, 4);
            var guidStr = idStr + randomStr;

            return new Guid(guidStr);
        }
    }
}
