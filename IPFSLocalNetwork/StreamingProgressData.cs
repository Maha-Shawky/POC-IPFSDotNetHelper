using System;
using System.Runtime.InteropServices;

namespace Common.InteropDTO
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public class StreamingProgressData
    {
        public int progressPercentage;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public String caption;
        public double transfaredKBs;
        public double totalKBs;
        public IntPtr progressOwnerAddress;


        public StreamingProgressData()
        {
            progressPercentage = -1;
        }

        public void UpdateProgressPercentage()
        {
           progressPercentage =  (int)((double)transfaredKBs / totalKBs * 100.0);
        }
    }

}
