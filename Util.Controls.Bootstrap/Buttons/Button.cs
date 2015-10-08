using System;
using Util.Controls.Base;
using Util.Controls.Bootstrap.Enums;

namespace Util.Controls.Bootstrap.Buttons {
    /// <summary>
    /// 按钮
    /// </summary>
    public class Button : Button<IButton>, IButton {
        /// <summary>
        /// 初始化按钮
        /// </summary>
        /// <param name="text">按钮文本</param>
        public Button( string text ) : base( text ) {
        }
    }

    /// <summary>
    /// 按钮
    /// </summary>
    /// <typeparam name="TButton">按钮类型</typeparam>
    public abstract class Button<TButton> : ButtonBase<TButton> where TButton : IButton<TButton> {
        /// <summary>
        /// 初始化按钮
        /// </summary>
        /// <param name="text">按钮文本</param>
        protected Button( string text ) : base( text ) {
            Class( Config.Btn ).Style( ButtonStyle.Default );
            AddDataToggle( Config.Button );
        }

        /// <summary>
        /// 设置样式
        /// </summary>
        /// <param name="style">按钮样式</param>
        public TButton Style( ButtonStyle style ) {
            return Class( style.Description() );
        }

        /// <summary>
        /// 设置大小
        /// </summary>
        /// <param name="size">按钮大小</param>
        public TButton Size( ButtonSize size ) {
            return Class( size.Description() );
        }

        /// <summary>
        /// 设置为超小按钮
        /// </summary>
        public TButton Mini() {
            return Size( ButtonSize.Mini );
        }

        /// <summary>
        /// 设置为小按钮
        /// </summary>
        public TButton Small() {
            return Size( ButtonSize.Small );
        }

        /// <summary>
        /// 设置为大按钮
        /// </summary>
        public TButton Large() {
            return Size( ButtonSize.Large );
        }
    }
}
