using Microsoft.VisualStudio.TestTools.UnitTesting;
using Util.Controls.Bootstrap.Buttons;

namespace Util.Controls.Bootstrap.Tests.Buttons {
    /// <summary>
    /// 按钮测试
    /// </summary>
    [TestClass]
    public class ButtonTest {
        /// <summary>
        /// 按钮
        /// </summary>
        private Button _control;

        /// <summary>
        /// 测试初始化
        /// </summary>
        [TestInitialize]
        public void TestInit() {
            _control = new Button("a");
        }

        /// <summary>
        /// 默认输出
        /// </summary>
        [TestMethod]
        public void TestDefault() {
            var result = "<button type=\"button\" class=\"btn\" data-toggle=\"button\">a</button>";
            Assert.AreEqual( result, _control.ToHtmlString() );
        }

        /// <summary>
        /// 默认输出
        /// </summary>
        [TestMethod]
        public void TestId() {
            var result = "<button type=\"button\" class=\"btn\" data-toggle=\"button\">a</button>";
            Assert.AreEqual( result, _control.ToString() );
        }
    }
}
