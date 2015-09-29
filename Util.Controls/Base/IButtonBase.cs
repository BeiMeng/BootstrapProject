namespace Util.Controls.Base {
    /// <summary>
    /// 按钮
    /// </summary>
    /// <typeparam name="TButton">按钮类型</typeparam>
    public interface IButtonBase<out TButton> : IComponent<TButton> where TButton : IButtonBase<TButton> {
    }
}
