using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DWORD=System.Int32;
using HINSTANCE=System.IntPtr;
using HHOOK=System.Int32;

namespace KBHook
{
    public class NativeMethod
    {
        private const string KERNEL32 = "kernel32.dll";
        private const string USER32 = "user32.dll";

        [DllImport(KERNEL32)]
        public static extern int GetCurrentThreadId();

        [DllImport(USER32, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport(USER32, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern HHOOK SetWindowsHookEx(int idHook, HOOKPROC lpfn, HINSTANCE hMod, DWORD dwThreadId);
        //抽调钩子
        [DllImport(USER32, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport(USER32, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern short GetKeyState(int vKey);


    }
}
