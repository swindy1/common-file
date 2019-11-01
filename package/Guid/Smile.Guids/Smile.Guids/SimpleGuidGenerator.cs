using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Guids
{
    /// <summary>
    /// 简单Guid
    /// </summary>
    public class SimpleGuidGenerator : IGuidGenerator
    {
        private SimpleGuidGenerator() { }
        public static SimpleGuidGenerator Instance { get; } = new SimpleGuidGenerator();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual Guid Create()
        {
            return Guid.NewGuid();
        }
    }
}
