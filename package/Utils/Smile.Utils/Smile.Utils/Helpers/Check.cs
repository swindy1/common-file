using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Utils.Helpers
{
    public static class Check
    {
        /// <summary>
        /// 断言
        /// </summary>
        /// <typeparam name="TException"></typeparam>
        /// <param name="condition">判断条件</param>
        /// <param name="message">condition为false异常消息</param>
        private static void Need<TException>(bool condition, string message) where TException : Exception
        {
            if (condition) return;

            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentNullException();

            TException exception = (TException)Activator.CreateInstance(typeof(TException), message);
            throw exception;
        }


        /// <summary>
        /// 空类型检查
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="message"></param>
        public static void NotNull<T>(T value, string message)
        {
            Need<ArgumentNullException>(value == null, message);
        }

        /// <summary>
        /// 空类型检查
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        public static void NotNull<T>(T value)
        {
            Need<ArgumentNullException>(value == null, $"{value.GetType().Name} is null");
        }
    }
}
