namespace Util.Controls.Builders.Tags {
    /// <summary>
    /// 按钮标签生成器
    /// </summary>
    public class ButtonBuilder : TagBuilder {
        /// <summary>
        /// 初始化按钮标签生成器
        /// </summary>
        public ButtonBuilder() : base( "button" ) {
            AddAttribute( "type","button" );
        }
    }
}
