using System.ComponentModel;

namespace Util.Controls.Bootstrap.Enums {
    /// <summary>
    /// 按钮样式
    /// </summary>
    public enum ButtonStyle {
        /// <summary>
        /// 默认样式
        /// </summary>
        [Description( "btn-default" )]
        Default,
        /// <summary>
        /// 重点蓝
        /// </summary>
        [Description( "btn-primary" )]
        Primary,
        /// <summary>
        /// 成功绿
        /// </summary>
        [Description( "btn-success" )]
        Success,
        /// <summary>
        /// 信息蓝
        /// </summary>
        [Description( "btn-info" )]
        Info,
        /// <summary>
        /// 警告橙
        /// </summary>
        [Description( "btn-warning" )]
        Warning,
        /// <summary>
        /// 危险红
        /// </summary>
        [Description( "btn-danger" )]
        Danger
    }
}
