using System.Configuration;
using System.Text;

namespace Util {
    /// <summary>
    /// 配置
    /// </summary>
    public static class Config {

        #region GetAppSettings(获取appSettings)

        /// <summary>
        /// 获取appSettings
        /// </summary>
        /// <param name="key">键名</param>
        public static string GetAppSettings( string key ) {
            return ConfigurationManager.AppSettings[key];
        }

        #endregion

        #region GetConnectionString(获取连接字符串)

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <param name="key">键名</param>        
        public static string GetConnectionString( string key ) {
            return ConfigurationManager.ConnectionStrings[key].ToString();
        }

        #endregion

        #region GetProviderName(获取数据提供程序名称)

        /// <summary>
        /// 获取数据提供程序名称
        /// </summary>
        /// <param name="key">键名</param>
        public static string GetProviderName( string key ) {
            return ConfigurationManager.ConnectionStrings[key].ProviderName;
        }

        #endregion

        #region DefaultEncoding(默认编码)

        /// <summary>
        /// 默认编码,值为utf-8
        /// </summary>
        public static Encoding DefaultEncoding {
            get { return Encoding.GetEncoding( "utf-8" ); }
        }

        #endregion

        #region GetKey(获取临时加密密钥)

        /// <summary>
        /// 获取临时加密密钥
        /// </summary>
        public static string GetKey() {
            return "#s^un2ye21fcn%|f0XpR,+vh";
        }

        #endregion

        #region GetStoreKey(获取存储加密密钥)

        /// <summary>
        /// 获取存储加密密钥
        /// </summary>
        public static string GetStoreKey() {
            return "v^un2d#eI1@Q2%|,a0xO+sJR";
        }

        #endregion

        #region LogContextKey(获取日志上下文键名)

        /// <summary>
        /// 获取日志上下文键名
        /// </summary>
        public static string LogContextKey {
            get { return "Util.Logs.LogContext"; }
        }

        #endregion

        #region SqlTraceLogName(获取Sql跟踪日志名)

        /// <summary>
        /// 获取Sql跟踪日志名
        /// </summary>
        public static string SqlTraceLogName {
            get { return "SqlTraceLog"; }
        }

        #endregion

        #region AuthorizeTraceLogName(获取授权跟踪日志名)

        /// <summary>
        /// 获取授权跟踪日志名
        /// </summary>
        public static string AuthorizeTraceLogName {
            get { return "AuthorizeTraceLog"; }
        }

        #endregion

        #region MvcTraceLogName(获取Mvc跟踪日志名)

        /// <summary>
        /// 获取Mvc跟踪日志名
        /// </summary>
        public static string MvcTraceLogName {
            get { return "MvcTraceLog"; }
        }

        #endregion

        #region ControlTraceLogName(获取控件跟踪日志名)

        /// <summary>
        /// 获取控件跟踪日志名
        /// </summary>
        public static string ControlTraceLogName {
            get { return "ControlTraceLog"; }
        }

        #endregion
    }
}
