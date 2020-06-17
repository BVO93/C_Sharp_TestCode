using System;

namespace EventsAndDelegates
{
    public class NotificationOfDownload
    {
        public void OnFileDownloaded(object source, FileEventAgs e)
        {
            System.Console.WriteLine("File is been downloaded" + e.File.Title);
        }
    }
}
