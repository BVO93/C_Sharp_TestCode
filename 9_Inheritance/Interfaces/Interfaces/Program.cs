using System;

namespace Interfaces
{
    public interface INotifications
    {
        // Memebers 
        void showNotification();
        string getDate();
    }


    public class Notification : INotifications
    {
        // It will give errors unitl all the members are implmented.

        //*******  PROPERTIES *******//
        // private
        private string sender;
        private string message;
        private string date;

        //*******  CONSTRUCTOR  *******//
        //Default 
        public Notification()
        {
            sender = "admin";
            message = "hello";
            date = "";
        }

        // Extended 
        public Notification(string sender , string message , string date)
        {
            this.sender = sender;
            this.message = message;
            this.date = date;
        }


        //*******  MEMBERS  *******//
      public  void showNotification()
        {
            Console.WriteLine("Message {0} - was send {1} at {2}" , message, sender, date);
        }

       public string getDate()
        {
            return date;
        }

    }


    // MAIN Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Notification n1 = new Notification("Bjorn", "No message", "8.6.2018");
            Notification n2 = new Notification("Jo", "TestTest", "12.12.12");

            n1.showNotification();
            n2.showNotification();

        
        }
    }
}
