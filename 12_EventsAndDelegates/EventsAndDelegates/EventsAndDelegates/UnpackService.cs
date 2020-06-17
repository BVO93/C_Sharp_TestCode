using System;

namespace EventsAndDelegates
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventAgs e)
        {
            Console.WriteLine("Unpackerservice: Unpacking..." + e.File.Title);
        }
    }
}
