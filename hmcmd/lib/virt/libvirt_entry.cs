using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmcmd.lib.virt
{
    /// <summary>
    /// libvirt 模块入口点
    /// </summary>
    public static class libvirt_entry
    {
        /// <summary>
        /// 主入口
        /// </summary>
        /// <param name="args">入口参数</param>
        public static void Entry(string[] args)
        {
            Application.Run(new libvirt_frmMain());
        }
    }
}
