using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmcmd
{
    public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// <param name="args">运行参数</param>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartupPath = Application.StartupPath;
            FileInfo fi = new FileInfo(Application.ExecutablePath);
            Prog = fi.Name.Replace(fi.Extension, "");
            BasePath = fi.DirectoryName;

            EnterModule(args);
        }

        /// <summary>
        /// 程序的启动路径
        /// </summary>
        public static string StartupPath { get; private set; }

        /// <summary>
        /// 程序的基础路径
        /// </summary>

        public static string BasePath { get; private set; }

        /// <summary>
        /// 执行的程序名称
        /// </summary>

        public static string Prog { get; private set; }

        /// <summary>
        /// 程序的处理通用入口点
        /// </summary>
        /// <param name="args">运行参数</param>
        private static void EnterModule(string[] args)
        {
           Regex regex=new Regex("[-].*");
            if (args.Length > 0)
            {
                if (!regex.IsMatch(args[0]))
                {
                    List <string> rargs=new List<string>(args);
                    rargs.RemoveAt(0);
                    RedirectModule(args[0],rargs.ToArray());
                }
                else
                {
                    RedirectModule(Prog, args);
                }
            }
            else
            {
                RedirectModule(Prog,args);
            }
        }

        /// <summary>
        /// 程序的处理跳转点
        /// </summary>
        /// <param name="module">子程序</param>
        /// <param name="args">参数</param>
        private static void RedirectModule(string module, string[] args)
        {
            switch (module)
            {
                case "libvirt":
                case "virt":
                case "virtman":
                case "virt-man":
                    lib.virt.libvirt_entry.Entry(args.ToArray());
                    break;
                default:
                    //TODO:这是模块指定出错的处理
                    int i = 0;
                    break;
            }
        }
    }
}
