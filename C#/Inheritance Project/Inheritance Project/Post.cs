using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Project
{
    class Post
    {
        //    Due to its static ability, whenever new Post object create, this will
        //        also get update and it will be with all Post object with an increament update.
        private static int currentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }

        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Supavich Aussawa";
        }
        public Post(string title,bool isPublic,string sendByUsername)
        {
            this.ID = GetNextID();
            Title = title;
            IsPublic = isPublic;
            SendByUsername = sendByUsername;
            
        }
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", ID, Title, SendByUsername);
        }
    }

}
