using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HMKernel.NativeCallback;
using DWORD = System.UInt64;
using DWORD32 = System.Int32;
using HINSTANCE = System.IntPtr;
using HANDLE = System.IntPtr;
using HWND = System.IntPtr;
using HMODULE = System.IntPtr;
using HICON = System.IntPtr;
using HHOOK = System.Int32;
using LPDWORD=System.UInt64;
using BOOL = System.Int32;
using UINT = System.UInt32;

namespace HMKernel
{
    public class NativeMethod
    {
        private const string KERNEL32 = "kernel32.dll";
        private const string USER32 = "user32.dll";
        private const string SHELL32 = "shell32.dll";

        [CPlusPlus]
        public const int TRUE = 1;

        [CPlusPlus]
        public const int FALSE = 0;

        [DllImport(USER32)]
        public static extern DWORD GetWindowThreadProcessId(HWND hWnd, ref LPDWORD lpdwProcessId);

        [DllImport(USER32)]
        public static extern BOOL IsWindowVisible(HWND hWnd);

        [DllImport(USER32)]
        public static extern int EnumWindows(EnumWindowsCallback lpfn,DWORD32 lParam);

        [DllImport(USER32,SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, DWORD32 nMaxCount);

        [DllImport(USER32)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder szTitle, DWORD32 nMaxCount);

        [DllImport(KERNEL32)]
        public extern static HANDLE OpenProcess(DWORD dwDesiredAccess, BOOL bInheritHandle, DWORD dwProcessId);

        [DllImport(KERNEL32)]
        public extern static bool TerminateProcess(HANDLE hProcess, UINT uExitCode);

        [DllImport(KERNEL32)]
        public extern static BOOL CloseHandle(HANDLE hObject);

        [DllImport(KERNEL32, EntryPoint = "GetModuleFileName")]
        private static extern DWORD GetModuleFileName(HMODULE hModule, [Out] StringBuilder lpszFileName, DWORD nSize);

        [DllImport(SHELL32)]
        public static extern UINT ExtractIconEx(string lpszFile, int nIconIndex, ref HICON phiconLarge, ref HICON phiconSmall, UINT nIcons);
    }
}
