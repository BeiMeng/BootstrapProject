namespace Util.Controls.Builders.Tags {
    /// <summary>
    /// 输入标签生成器
    /// </summary>
    public class InputBuilder : TagBuilder {
        /// <summary>
        /// 初始化输入标签生成器
        /// </summary>
        public InputBuilder() : base( "input" ) {
        }

        /// <summary>
        /// 获取渲染结果
        /// </summary>
        protected override string GetResult() {
            return string.Format( "<{0} {1}/>", TagName, GetOptions() );
        }
    }
}
