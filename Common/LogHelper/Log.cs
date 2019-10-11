using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
namespace Common.LogHelper
{
    /// <summary>
    /// 日志
    /// </summary>
    public class Log
    {
        private ILog logger;
        public Log(ILog log)
        {
            this.logger = log;
        }
        /// <summary>
        /// 调试日志
        /// </summary>
        /// <param name="message">日志操作对象</param>
        public void Debug(object message)
        {
            logger.Debug(message);
        }
        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="message">日志操作对象</param>
        public void Error(object message)
        {
            logger.Error(message);
        }
        /// <summary>
        /// 信息日志
        /// </summary>
        /// <param name="message">日志操作对象</param>
        public void Info(object message)
        {
            logger.Info(message);
        }
        /// <summary>
        /// 警告日志
        /// </summary>
        /// <param name="message">日志操作对象</param>
        public void Warn(object message)
        {
            logger.Warn(message);
        }
    }
}
