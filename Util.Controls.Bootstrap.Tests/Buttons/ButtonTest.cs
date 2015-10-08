using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Util.Controls.Bootstrap.Buttons;
using Util.Controls.Bootstrap.Enums;

namespace Util.Controls.Bootstrap.Tests.Buttons
{
    /// <summary>
    /// 按钮测试
    /// </summary>
    [TestClass]
    public class ButtonTest
    {
        /// <summary>
        /// 按钮
        /// </summary>
        private Button _control;

        /// <summary>
        /// 测试初始化
        /// </summary>
        [TestInitialize]
        public void TestInit()
        {
            _control = new Button("a");
        }

        /// <summary>
        /// 断言结果
        /// </summary>
        private void AssertResult(string @class = "", string options = "")
        {
            @class = @class.IsEmpty() ? "" : " " + @class;
            options = options.IsEmpty() ? "" : " " + options;
            Str result = new Str();
            result.Append("<button type=\"button\" class=\"btn btn-default{0}\" data-toggle=\"button\"{1}>", @class, options);
            result.Append("a</button>");
            Assert.AreEqual(result.ToString(), _control.ToHtmlString());
            Console.WriteLine(result.ToString());
        }

        /// <summary>
        /// 默认输出
        /// </summary>
        [TestMethod]
        public void TestDefault()
        {
            AssertResult();
        }

        /// <summary>
        /// 按钮样式
        /// </summary>
        [TestMethod]
        public void TestStyle_Default()
        {
            _control.Style(ButtonStyle.Default);
            AssertResult("btn-default");
        }

        /// <summary>
        /// 按钮样式
        /// </summary>
        [TestMethod]
        public void TestStyle_Info()
        {
            _control.Style(ButtonStyle.Info);
            AssertResult("btn-info");
        }

        /// <summary>
        /// 按钮样式
        /// </summary>
        [TestMethod]
        public void TestStyle_Primary()
        {
            _control.Style(ButtonStyle.Primary);
            AssertResult("btn-primary");
        }

        /// <summary>
        /// 按钮样式
        /// </summary>
        [TestMethod]
        public void TestStyle_Success()
        {
            _control.Style(ButtonStyle.Success);
            AssertResult("btn-success");
        }

        /// <summary>
        /// 按钮样式
        /// </summary>
        [TestMethod]
        public void TestStyle_Warning()
        {
            _control.Style(ButtonStyle.Warning);
            AssertResult("btn-warning");
        }

        /// <summary>
        /// 按钮样式
        /// </summary>
        [TestMethod]
        public void TestStyle_Danger()
        {
            _control.Style(ButtonStyle.Danger);
            AssertResult("btn-danger");
        }

        /// <summary>
        /// 按钮大小
        /// </summary>
        [TestMethod]
        public void TestSize_Mini()
        {
            _control.Size(ButtonSize.Mini);
            AssertResult("btn-xs");
        }

        /// <summary>
        /// 按钮大小
        /// </summary>
        [TestMethod]
        public void TestSize_Small()
        {
            _control.Size(ButtonSize.Small);
            AssertResult("btn-sm");
        }

        /// <summary>
        /// 按钮大小
        /// </summary>
        [TestMethod]
        public void TestSize_Large()
        {
            _control.Size(ButtonSize.Large);
            AssertResult("btn-lg");
        }

        /// <summary>
        /// 设置为超小按钮
        /// </summary>
        [TestMethod]
        public void TestMini()
        {
            _control.Mini();
            AssertResult("btn-xs");
        }

        /// <summary>
        /// 设置为小按钮
        /// </summary>
        [TestMethod]
        public void TestSmall()
        {
            _control.Small();
            AssertResult("btn-sm");
        }

        /// <summary>
        /// 设置为大按钮
        /// </summary>
        [TestMethod]
        public void TestLarge()
        {
            _control.Large();
            AssertResult("btn-lg");
        }
    }
}
