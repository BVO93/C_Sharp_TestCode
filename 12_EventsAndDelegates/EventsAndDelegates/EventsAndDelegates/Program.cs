namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new File() { Title = "File 1" };
            var downloadHelper = new DownloadHelper(); // Publisher
            var unpackService = new UnpackService();   // Receiver
            var notificationOfDownload = new NotificationOfDownload(); // Receiver
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloaded += notificationOfDownload.OnFileDownloaded;
            downloadHelper.Download(file);


        }

    }
}
