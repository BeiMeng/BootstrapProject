using Util.Controls.Bootstrap.Buttons;

namespace Util.Controls.Bootstrap.Services {
    /// <summary>
    /// Bootstrap组件服务
    /// </summary>
    public interface IBootstrapService<TEntity> {
        /// <summary>
        /// 按钮
        /// </summary>
        /// <param name="text">按钮文本</param>
        IButton Button( string text );
    }
}
