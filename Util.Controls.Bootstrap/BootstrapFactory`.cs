using System.Web.Mvc;
using Util.Controls.Bootstrap.Services;

namespace Util.Controls.Bootstrap {
    /// <summary>
    /// Bootstrap组件工厂
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    public class BootstrapFactory<TEntity> {
        /// <summary>
        /// 创建Bootstrap组件服务
        /// </summary>
        public static IBootstrapService<TEntity> CreateBootstrapService( HtmlHelper<TEntity> helper ) {
            return new BootstrapService<TEntity>( helper );
        }
    }
}
