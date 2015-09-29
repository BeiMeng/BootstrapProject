using System.Web.Mvc;
using Util.Controls.Bootstrap.Services;

namespace Util.Controls.Bootstrap {
    /// <summary>
    /// HtmlHelper扩展 - Bootstrap扩展
    /// </summary>
    public static class HtmlHelperExtentions {
        /// <summary>
        /// 创建Bootstrap组件服务
        /// </summary>
        /// <param name="helper">HtmlHelper</param>
        public static IBootstrapService<T> Bootstrap<T>( this HtmlHelper<T> helper ) {
            return BootstrapFactory<T>.CreateBootstrapService( helper );
        }
    }
}
