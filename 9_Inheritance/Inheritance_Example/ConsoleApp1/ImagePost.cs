using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // : name of class to inherit from
    class ImagePost: Post
    {
        //*******  PROPERTIES *******//
        // PUBLIC 
        public string ImageURL { get; set; }
       


        //******* CONSTRUCTOR *******??
        // DEFAULT
        public ImagePost() { }

        // EXTENDED
        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            this.ID = getNextID();
            this.sendByUserName = sendByUserName;
            this.Title = title;
            this.IsPublic = isPublic;
            // Member of imagePost not of Post
            this.ImageURL = imageURL;
        }



        //*******  METHODS  *******//




        //*******  OVERRIDE  *******//

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} - on {3}", this.ID, this.Title, this.sendByUserName, this.ImageURL);
        }

    }
}
