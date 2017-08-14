using KBHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMShell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i=NativeMethod.SetWindowsHookEx(HookID.WH_KEYBOARD_LL, kbproc, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
            Text = i.ToString();
        }

        private int kbproc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0)
            {
                KeyboardHookStruct kbh = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
                Text = ((VirtualKeyCode)kbh.vkCode).ToString();
                if (((int)wParam != (int)KeyBoardWParam.WM_KEYDOWN)) return 0;
                if (kbh.vkCode == (int)VirtualKeyCode.VK_F4 && 
                    NativeMethod.GetKeyState((int)VirtualKeyCode.VK_MENU)<0)
                {
                    Text = "ALT+F4";
                    return 1;
                }
                if (kbh.vkCode == (int)VirtualKeyCode.VK_DELETE &&
                    NativeMethod.GetKeyState((int)VirtualKeyCode.VK_MENU) < 0
                    && NativeMethod.GetKeyState((int)VirtualKeyCode.VK_CONTROL) < 0)
                {
                    Text = "CTRL+ALT+DEL";
                    return 1;
                }
            }
            return 0;
        }
    }
}
