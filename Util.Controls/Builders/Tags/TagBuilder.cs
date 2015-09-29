using System.Text;

namespace Util.Controls.Builders.Tags {
    /// <summary>
    /// 标签生成器
    /// </summary>
    public class TagBuilder {
        /// <summary>
        /// 初始化标签生成器
        /// </summary>
        /// <param name="tagName">标签名称，范例：div</param>
        public TagBuilder( string tagName ) {
            _attributeBuilder = new AttributeBuilder();
            TagName = tagName;
        }

        /// <summary>
        /// 属性生成器
        /// </summary>
        private readonly AttributeBuilder _attributeBuilder;

        /// <summary>
        /// 标签名称
        /// </summary>
        protected readonly string TagName;

        /// <summary>
        /// 添加属性
        /// </summary>
        /// <param name="name">属性名,范例：class</param>
        /// <param name="value">属性值</param>
        public void AddAttribute( string name, string value ) {
            _attributeBuilder.Add( name, value );
        }

        /// <summary>
        /// 更新属性
        /// </summary>
        /// <param name="name">属性名,范例：class</param>
        /// <param name="value">属性值</param>
        public void UpdateAttribute( string name, string value ) {
            _attributeBuilder.Update( name, value );
        }

        /// <summary>
        /// 添加style属性
        /// </summary>
        /// <param name="name">style属性名</param>
        /// <param name="value">style属性值</param>
        public void AddStyle( string name, string value ) {
            _attributeBuilder.AddStyle( name,value );
        }

        /// <summary>
        /// 添加class属性
        /// </summary>
        /// <param name="class">class属性值</param>
        public void AddClass( string @class ) {
            _attributeBuilder.AddClass( @class );
        }

        /// <summary>
        /// 获取Html结果
        /// </summary>
        public override string ToString() {
            var result = new StringBuilder();
            result.Append( GetBeforeHtml() );
            result.AppendFormat( GetResult() );
            result.Append( GetAfterHtml() );
            return result.ToString();
        }

        /// <summary>
        /// 获取标签前Html
        /// </summary>
        protected virtual string GetBeforeHtml() {
            return string.Empty;
        }

        /// <summary>
        /// 获取渲染结果
        /// </summary>
        protected virtual string GetResult() {
            return string.Format( "<{0}{1}>{2}</{0}>", TagName, GetOptions(), GetInnerHtml() );
        }

        /// <summary>
        /// 获取标签选项
        /// </summary>
        protected virtual string GetOptions() {
            var result = _attributeBuilder.ToString();
            if( result.IsEmpty() )
                return string.Empty;
            return string.Format( " {0}", result );
        }

        /// <summary>
        /// 获取标签内部Html
        /// </summary>
        protected virtual string GetInnerHtml() {
            return string.Empty;
        }

        /// <summary>
        /// 获取标签后Html
        /// </summary>
        protected virtual string GetAfterHtml() {
            return string.Empty;
        }
    }
}
