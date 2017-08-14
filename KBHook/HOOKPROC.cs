using LRESULT=System.Int32;
using HRESULT=System.Int32;
using WPARAM=System.IntPtr;
using LPARAM=System.IntPtr;

namespace KBHook
{
    public delegate LRESULT HOOKPROC(int code, WPARAM wParam, LPARAM lParam);
}