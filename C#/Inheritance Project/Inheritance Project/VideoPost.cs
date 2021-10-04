using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Inheritance_Project
{
    class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        public string VideoURL { get; set; }
        public int LengthOfVideo { get; set; }
        Timer timer;
        public VideoPost()
        {

        }
        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int lengthOfVideo)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            VideoURL = videoURL;
            IsPublic = isPublic;
            LengthOfVideo = lengthOfVideo;

        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4}", ID, Title, SendByUsername, VideoURL, LengthOfVideo);
        }
        public void Play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
                
                isPlaying = true;
            }

        }
        private void TimerCallback(object o)
        {
            if (currDuration < LengthOfVideo)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                Console.WriteLine("Stop at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
                isPlaying = false;
            }


        }
    }
}
