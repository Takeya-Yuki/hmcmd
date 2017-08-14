using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KBHook
{
    public class HookID
    {
        public static int WH_CALLWNDPROC = 4;
        public static int WH_CALLWNDPROCRET = 12;
        public static int WH_CBT = 5;
        public static int WH_DEBUG = 9;
        public static int WH_FOREGROUNDIDLE = 11;
        public static int WH_GETMESSAGE = 3;
        public static int WH_JOURNALPLAYBACK = 1;
        public static int WH_JOURNALRECORD = 0;
        public static int WH_KEYBOARD = 2;
        public static int WH_KEYBOARD_LL = 13;
        public static int WH_MOUSE = 7;
        public static int WH_MOUSE_LL = 14;
        public static int WH_MSGFILTER = -1;
        public static int WH_SHELL = 10;
        public static int WH_SYSMSGFILTER = 6;
    }
}
