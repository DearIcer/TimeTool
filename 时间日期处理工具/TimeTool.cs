using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 时间日期处理工具
{
    public static class TimeTool
    {
        /// <summary>
        ///  时间戳转为+00:00时区 日期格式  yyyy/MM/dd HH:mm:ss
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime GetUtcDateTime(string timeStamp)
        {
            try
            {
                long lTime = long.Parse(timeStamp);
                return DateTimeOffset.FromUnixTimeSeconds(lTime).DateTime;
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }


        /// <summary>
        ///  时间戳转为本地日期格式 yyyy/MM/dd HH:mm:ss
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime GetDateTime(string timeStamp)
        {
            try
            {
                long lTime = long.Parse(timeStamp);
                return DateTimeOffset.FromUnixTimeSeconds(lTime).LocalDateTime;
            }
            catch (Exception)
            {

                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// 日期转时间戳 ， 精确到秒
        /// </summary>
        /// <returns></returns>
        public static string ToSecondsTimeStamp(this DateTime dateTime)
        {
            try
            {
                return ((dateTime.ToUniversalTime().Ticks - 621355968000000000) / 10000000).ToString();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 日期转时间戳 ， 精确到毫秒
        /// </summary>
        /// <returns></returns>
        public static string ToMillisecondsTimeStamp(this DateTime dateTime)
        {
            try
            {
                return ((dateTime.ToUniversalTime().Ticks - 621355968000000000) / 10000).ToString();
            }
            catch (Exception)
            {

                return string.Empty;
            }
        }

        /// <summary>
        /// 计算一个时间戳与当前时间的间隔
        /// </summary>
        ///<param name="timeStamp"></param>
        /// <returns></returns>
        public static TimeSpan GetTimeSpan(string timeStamp)
        {
            try
            {
                long lTime = long.Parse(timeStamp);
                var DateTimeUnix = DateTimeOffset.FromUnixTimeSeconds(lTime);
                //计算两个时间间隔
                TimeSpan timeSpan = new(DateTimeOffset.UtcNow.Ticks - DateTimeUnix.Ticks);
                return timeSpan;
            }
            catch (Exception)
            {
                return new TimeSpan();
            }
        }

        /// <summary>
        /// 计算两个时间戳的间隔
        /// </summary>
        ///<param name="timeStamp1"></param>
        ///<param name="timeStamp2"></param>
        /// <returns></returns>
        public static TimeSpan GetTwoTimeSpan(string timeStamp1, string timeStamp2)
        {
            try
            {
                //获取时间戳，并将其转换为DateTimeOffset
                //var UninTimeStamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                long lTime1 = long.Parse(timeStamp1);
                long lTime2 = long.Parse(timeStamp2);
                var DateTimeUnix1 = DateTimeOffset.FromUnixTimeSeconds(lTime1);
                var DateTimeUnix2 = DateTimeOffset.FromUnixTimeSeconds(lTime2);
                //计算两个时间间隔
                TimeSpan timeSpan = new(DateTimeUnix2.Ticks - DateTimeUnix1.Ticks);
                return timeSpan;
            }
            catch (Exception)
            {
                return new TimeSpan();
            }
        }
    }
}
