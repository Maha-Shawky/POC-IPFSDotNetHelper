using System;
using System.IO;


namespace IPFSLocalNetwork.Progress
{
    public class FileStreamWithProgress : FileStream
    {
        private StreamingProgressData _streamingProgressData;

        public delegate void DownloadProgressDelegate(StreamingProgressData syVendorStreamingProgress);
        public DownloadProgressDelegate ProgressCallBack;

        public StreamingProgressData StreamingProgressData
        {
            get { return _streamingProgressData; }
            set { _streamingProgressData = value; }
        }

        public FileStreamWithProgress(string path, FileMode mode)
            : base(path, mode)
        {
            _streamingProgressData = new StreamingProgressData();
        }

        public FileStreamWithProgress(string path, FileMode mode, FileAccess access)
            : base(path, mode, access)
        {
            _streamingProgressData = new StreamingProgressData();
        }

        private void UpdateProgressInfo(int nNewBytes)
        {
            int oldPercentatge = _streamingProgressData.progressPercentage;

            _streamingProgressData.transfaredKBs += ((double)nNewBytes / 1024);
            _streamingProgressData.UpdateProgressPercentage();

            int newPercentatge = _streamingProgressData.progressPercentage;

            ////string logPathDeleteMe = @"C:\Users\Maha Saad\Desktop\Temp\log2.txt";
            //string logPathDeleteMe = "log2.txt";
            //File.AppendAllText(logPathDeleteMe, string.Format("nRead = {0}\t transfared = {1}\t Position = {2}\t total = {3}\t Progress = {4}\n",
            //    nNewBytes, _streamingProgressData.transfaredKBs, Position / 1024, _streamingProgressData.totalKBs, _streamingProgressData.progressPercentage));


            var handler = ProgressCallBack;
            if (handler != null && oldPercentatge != newPercentatge && newPercentatge <= 100)
            {
               // Debug.WriteLine("vendor = {0}\t nRead = {1}\t transfared = {2}\t Position = {3}\t total = {4}\t Progress = {5}",_streamingProgressData.caption,
                //nNewBytes, _streamingProgressData.transfaredKBs, this.Position / 1024, _streamingProgressData.totalKBs, _streamingProgressData.progressPercentage);


                ProgressCallBack(_streamingProgressData);

            }
        }

        public void SetTotalLength(long totalLength)
        {
            _streamingProgressData.totalKBs = (double)totalLength / 1024;
        }

        public void SetCaption(string caption)
        {
            _streamingProgressData.caption = caption;
        }

        public void SetProgressOwnerAddress(IntPtr progressOwnerAddress)
        {
            _streamingProgressData.progressOwnerAddress = progressOwnerAddress;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            base.Write(buffer, offset, count);
            UpdateProgressInfo(count);
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int nRead = base.Read(buffer, offset, count);
            UpdateProgressInfo(nRead);
            return nRead;
        }

    }
}
