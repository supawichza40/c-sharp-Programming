using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    class ImagePost:Post
    {
        public string ImageURL { get; set; }
        public ImagePost() 
        {

        }
        public ImagePost(string title,string sendByUsername,string imageURL,bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;

            ImageURL = imageURL;

        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", ID, Title, SendByUsername,ImageURL);
        }
    }
}
