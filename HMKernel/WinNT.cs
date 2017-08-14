using System;
using System.Collections.Generic;
using System.Text;

namespace HMKernel
{
    public static class WinNT
    {
        public const long DELETE = (0x00010000L);
        public const long READ_CONTROL = (0x00020000L);
        public const long WRITE_DAC = (0x00040000L);
        public const long WRITE_OWNER = (0x00080000L);
        public const long SYNCHRONIZE = (0x00100000L);
        public const long STANDARD_RIGHTS_REQUIRED = (0x000F0000L);
        public const long STANDARD_RIGHTS_READ = (READ_CONTROL);
        public const long STANDARD_RIGHTS_WRITE = (READ_CONTROL);
        public const long STANDARD_RIGHTS_EXECUTE = (READ_CONTROL);
        public const long STANDARD_RIGHTS_ALL = (0x001F0000L);
        public const long SPECIFIC_RIGHTS_ALL = (0x0000FFFFL);
        public const long PROCESS_TERMINATE = (0x0001);
        public const long PROCESS_CREATE_THREAD = (0x0002);
        public const long PROCESS_SET_SESSIONID = (0x0004);
        public const long PROCESS_VM_OPERATION = (0x0008);
        public const long PROCESS_VM_READ = (0x0010);
        public const long PROCESS_VM_WRITE = (0x0020);
        public const long PROCESS_DUP_HANDLE = (0x0040);
        public const long PROCESS_CREATE_PROCESS = (0x0080);
        public const long PROCESS_SET_QUOTA = (0x0100);
        public const long PROCESS_SET_INFORMATION = (0x0200);
        public const long PROCESS_QUERY_INFORMATION = (0x0400);
        public const long PROCESS_SUSPEND_RESUME = (0x0800);
        public const long PROCESS_QUERY_LIMITED_INFORMATION = (0x1000);
        public const long PROCESS_SET_LIMITED_INFORMATION = (0x2000);
        public const long PROCESS_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xFFFF);
    }
}
