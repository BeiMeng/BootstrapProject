using Util.Controls.Base;

namespace Util.Controls.Bootstrap.Buttons {
    /// <summary>
    /// 按钮
    /// </summary>
    public interface IButton : IButton<IButton> {
    }

    /// <summary>
    /// 按钮
    /// </summary>
    /// <typeparam name="TButton">按钮类型</typeparam>
    public interface IButton<out TButton> : IButtonBase<TButton> where TButton : IButton<TButton> {
    }
}
