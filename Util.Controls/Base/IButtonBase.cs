namespace Util.Controls.Base {
    /// <summary>
    /// 按钮
    /// </summary>
    /// <typeparam name="TButton">按钮类型</typeparam>
    public interface IButtonBase<out TButton> : IComponent<TButton> where TButton : IButtonBase<TButton> {
        /// <summary>
        /// 禁用按钮
        /// </summary>
        TButton Disable();
        /// <summary>
        /// 设置单击事件处理函数
        /// </summary>
        /// <param name="handler">事件处理函数或Js代码,范例: fun() 或 alert('1');</param>
        TButton Click( string handler );
    }
}
