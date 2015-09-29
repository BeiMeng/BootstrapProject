namespace Util.Controls.Bootstrap.Buttons {
    /// <summary>
    /// 按钮
    /// </summary>
    public class Button : Button<IButton> {
        public Button( string text ) {
        }
    }

    /// <summary>
    /// 按钮
    /// </summary>
    /// <typeparam name="TButton">按钮类型</typeparam>
    public abstract class Button<TButton> {
    }
}
