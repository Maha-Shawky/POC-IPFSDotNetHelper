using System;
using System.Runtime.InteropServices;

namespace IPFSLocalNetwork.Progress
{
    public class StreamingProgressData
    {
        public int progressPercentage;
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
