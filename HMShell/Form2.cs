using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMKernel;

namespace HMShell
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                listBox1.Items.Clear();
            NativeMethod.EnumWindows((wnd, param) =>
            {
                if (NativeMethod.IsWindowVisible(wnd) == NativeMethod.TRUE)
                {
                    StringBuilder szClass = new StringBuilder(256);
                    NativeMethod.GetClassName(wnd, szClass, 256);
                    StringBuilder szTitle = new StringBuilder(256);
                    NativeMethod.GetWindowText(wnd, szTitle, 256);
                    ulong thread = 0;
                    NativeMethod.GetWindowThreadProcessId(wnd, ref thread);
                    Process p = Process.GetProcessById((int) thread);
                    listBox1.Items.Add(
                        $@"{p.ProcessName}({thread}):{szTitle}:{szClass}");
                }
                return true;
            }, 0);
        }
    }
}
