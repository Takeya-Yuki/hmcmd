using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWND = System.IntPtr;
using LPARAM=System.IntPtr;

namespace HMKernel
{
    namespace NativeCallback
    {
        public delegate bool EnumWindowsCallback(HWND hWnd, LPARAM lParam);
    }
}
