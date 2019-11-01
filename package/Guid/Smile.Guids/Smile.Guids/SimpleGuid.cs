using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Guids
{
    /// <summary>
    /// 简单Guid
    /// </summary>
    public class SimpleGuid : IGuidGenerrator
    {
        private SimpleGuid() { }
        public static SimpleGuid Instance { get; } = new SimpleGuid();

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
