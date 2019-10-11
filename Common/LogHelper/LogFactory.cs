using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.LogHelper
{
    public class LogFactory
    {
        static LogFactory()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        /// <summary>
        /// 获取日志操作对象
        /// </summary>
        /// <param name="name">名字</param>
        /// <returns></returns>
        public static Log GetLogger(string name)
        {
            return new Log(LogManager.GetLogger(name));
        }
        /// <summary>
        /// 获取日志操作对象
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns></returns>
        public static Log GetLogger(Type type)
        {
            return new Log(LogManager.GetLogger(type));
        }
    }
}
