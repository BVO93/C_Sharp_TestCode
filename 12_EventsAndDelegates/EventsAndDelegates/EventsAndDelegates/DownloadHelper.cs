using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class FileEventAgs: EventArgs
    {
        public File File { get; set; }
    }

    class DownloadHelper
    {
        // step 1 - create delegate
        public delegate void FileDownloadedEventHandler(object source, FileEventAgs args);

        // step 2 - create event baed on delegate
        public event FileDownloadedEventHandler FileDownloaded;

        // step 3 - raise event 
        protected virtual void OnFileDownloaded(File file)
        {
            if(FileDownloaded != null)
            {
                FileDownloaded(this, new FileEventAgs(){ File = file});
            }
        }

        public void Download(File file)
        {
            Console.WriteLine("Downloading file....");
            Thread.Sleep(4000);

            // step 3.1
            OnFileDownloaded( file);

        
       }

    }
}
