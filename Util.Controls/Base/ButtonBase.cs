using Util.Controls.Builders.Tags;

namespace Util.Controls.Base {
    /// <summary>
    /// 按钮
    /// </summary>
    /// <typeparam name="TButton">按钮类型</typeparam>
    public abstract class ButtonBase<TButton> : ComponentBase<TButton>,IButtonBase<TButton> where TButton : IButtonBase<TButton> {
        /// <summary>
        /// 初始化按钮
        /// </summary>
        /// <param name="text">按钮文本</param>
        protected ButtonBase( string text ) {
            TagBuilder = new ButtonBuilder();
            TagBuilder.AddClass( "btn" );
            TagBuilder.SetInnerHtml( text );
        }

        /// <summary>
        /// 标签生成器
        /// </summary>
        protected ButtonBuilder TagBuilder { get; private set; }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            return TagBuilder;
        }
    }
}
