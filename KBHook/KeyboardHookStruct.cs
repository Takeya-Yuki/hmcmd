using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KBHook
{
    [StructLayout(LayoutKind.Sequential)]
    public class KeyboardHookStruct
    {
        public int vkCode;//表达一个在1到254间的虚拟键盘码
        public int scanCode;//表示硬件扫描码
        public int flags;
        public int time;
        public int dwExtraInfo;
    }
}