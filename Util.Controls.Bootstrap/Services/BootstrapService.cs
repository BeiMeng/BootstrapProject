using System.Web.Mvc;

namespace Util.Controls.Bootstrap.Services {
    /// <summary>
    /// Bootstrap组件服务
    /// </summary>
    public class BootstrapService<TEntity> : IBootstrapService<TEntity> {
        /// <summary>
        /// 初始化Bootstrap组件服务
        /// </summary>
        /// <param name="helper">HtmlHelper</param>
        public BootstrapService( HtmlHelper<TEntity> helper ) {
            _helper = helper;
        }

        /// <summary>
        /// HtmlHelper
        /// </summary>
        private readonly HtmlHelper<TEntity> _helper;
    }
}
