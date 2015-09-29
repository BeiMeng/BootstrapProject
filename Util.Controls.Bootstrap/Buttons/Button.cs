using Util.Controls.Base;

namespace Util.Controls.Bootstrap.Buttons {
    /// <summary>
    /// 按钮
    /// </summary>
    public class Button : Button<IButton>, IButton {
        /// <summary>
        /// 初始化按钮
        /// </summary>
        /// <param name="text">按钮文本</param>
        public Button( string text ) : base(text){
        }
    }

    /// <summary>
    /// 按钮
    /// </summary>
    /// <typeparam name="TButton">按钮类型</typeparam>
    public abstract class Button<TButton> : ButtonBase<TButton> where TButton : IButton<TButton> {
        /// <summary>
        /// 初始化按钮
        /// </summary>
        /// <param name="text">按钮文本</param>
        protected Button( string text ) : base(text) {
            AddDataToggle( "button" );
        }
    }
}
