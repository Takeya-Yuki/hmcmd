using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmcmd.lib.virt
{
    /// <summary>
    /// libvert 模块入口点
    /// </summary>
    public static class libvert_entry
    {
        /// <summary>
        /// 主入口
        /// </summary>
        /// <param name="args">入口参数</param>
        public static void Entry(string[] args)
        {
            Application.Run(new libvert_frmMain());
        }
    }
}
