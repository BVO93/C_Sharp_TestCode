using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Post
    {
        //*******  PROPERTIES *******//
        
        // PRIVATE
        private static int currentPostId = 0; // Static so available everywhere 

        //PROTECTED
        protected int ID { get; set; } // only be used by this class en derived classes
        protected string Title { get; set; }
        protected string sendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        //PUBLIC

        // *******  CONSTRUCTOR *******//

        // DEFAULT
        // We define another cntructor. This will be the one the derived classes call.
        // If no constructor is defined,the default one will be used.
        public Post()
        {
            ID = getNextID();
            Title = "My First Post";
            IsPublic = true;
            sendByUserName = "Bjorn Van Olmen";
        }

        // EXTENDED 
        // Instance contructor that has three parameters
        // Make a constructor for if we provide data.
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = getNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.sendByUserName = sendByUserName;
        }



        // ****** METHODS ***** //

        // PRIVATE

        // PROTECTED
        protected int getNextID()
        {
            return ++currentPostId;
        }


        // PUBLIC
        public void Update(string title, bool isPublic)
        {
            this.Title = Title;
            this.IsPublic = isPublic;

        }


        //*******  OVERRIDE *******//

        // Overriding of the String class to return in o different way
        // So if we call ToString on something of class Post we will return this instead of the real ToString 
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.sendByUserName);
        }


    }
}
