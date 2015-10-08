using Util.Controls.Base;
using Util.Controls.Bootstrap.Enums;

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
        /// <summary>
        /// 设置样式
        /// </summary>
        /// <param name="style">按钮样式</param>
        TButton Style( ButtonStyle style );
        /// <summary>
        /// 设置大小
        /// </summary>
        /// <param name="size">按钮大小</param>
        TButton Size( ButtonSize size );
        /// <summary>
        /// 设置为超小按钮
        /// </summary>
        TButton Mini();
        /// <summary>
        /// 设置为小按钮
        /// </summary>
        TButton Small();
        /// <summary>
        /// 设置为大按钮
        /// </summary>
        TButton Large();
    }
}
