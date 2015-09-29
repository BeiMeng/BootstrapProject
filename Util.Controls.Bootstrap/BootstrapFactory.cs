using Util.Controls.Bootstrap.Buttons;

namespace Util.Controls.Bootstrap {
    /// <summary>
    /// Bootstrap组件工厂
    /// </summary>
    public class BootstrapFactory {
        /// <summary>
        /// 创建按钮
        /// </summary>
        /// <param name="text">按钮文本</param>
        public static IButton CreateButton( string text ) {
            return new Button( text );
        }
    }
}
