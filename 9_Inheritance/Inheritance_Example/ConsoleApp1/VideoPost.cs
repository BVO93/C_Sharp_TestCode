using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Inheritance
{
    class VideoPost: Post
    {
        //******* MEMBERFIELD  *******//
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        //*******  PROPERTIES  *******//
        //PUBLIC
       public System.Threading.Timer myTimer;
        public string videoURL { get; set; }
        public int length { get; set; }


        //*******  CONSTRUCTOR *******//
       //DEFUALT
        public VideoPost() { }

        //EXTENDED
        public VideoPost(string title, string sendByUserName,  string videoURL, int length, bool isPublic)
        {
            this.ID = getNextID();
            this.Title = title;
            this.sendByUserName = sendByUserName;
            this.IsPublic = isPublic; 
            
            this.videoURL = videoURL;
            this.length = length;
        }


        //*******  Methods  *******//
        //PUBLIC
        public void Play()
        {
            if (isPlaying == false) {
                isPlaying = true;
            Console.WriteLine("Playing....");
            // timer needs: callback, object, start , when to trigger (ms)
            timer = new Timer(TimerCallback, null, 0, 1000);
            }

        }

        public void Stop()
        {
            if (isPlaying == true)
            {
                Console.WriteLine("Stopt video at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
                isPlaying = false;
            }
        }

        //PRIVATE
        // Tmercallback heeft object nodig, noem het o als niet geimplement
        private void TimerCallback(object o)
        {
            if(currDuration < length)
            {
                currDuration++;
                Console.WriteLine("Video at {0} s", currDuration);
                // Garbage collector 
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }


        //*******  OVERRIDE *******//
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} - on {3} - length {4}", this.ID, this.Title, this.sendByUserName, this.videoURL, this.length);
        }

    }
}
