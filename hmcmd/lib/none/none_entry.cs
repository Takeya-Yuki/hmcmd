using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hmcmd.lib.virt;

namespace hmcmd.lib.none
{
    /// <summary>
    /// none模块主入口
    /// </summary>
    public static class none_entry
    {
        /// <summary>
        /// 主入口
        /// </summary>
        /// <param name="args">入口参数</param>
        public static void Entry(string[] args)
        {
            Application.Run(new none_frmMain());
        }
    }
}
