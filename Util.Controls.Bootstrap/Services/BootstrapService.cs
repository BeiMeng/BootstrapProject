using System.Web.Mvc;
using Util.Controls.Bootstrap.Buttons;

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

        /// <summary>
        /// 按钮
        /// </summary>
        /// <param name="text">按钮文本</param>
        public IButton Button( string text ) {
            return BootstrapFactory.CreateButton( text );
        }
    }
}
