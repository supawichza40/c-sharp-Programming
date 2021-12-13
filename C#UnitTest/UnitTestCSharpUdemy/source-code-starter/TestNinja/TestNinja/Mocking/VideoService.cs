using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using Moq;
using Newtonsoft.Json;

namespace TestNinja.Mocking
{
    public class VideoService
    {

        //public IFileReader FileReader { get; set; }//dependency injection via property#

        //In otherword, we need to create a function that work for fake and real one.
        public VideoService()
        {
            

        }
        public string ReadVideoTitle(IFileReader fileReader=null)
        {

            //Instead of working with concrete implementation like filereader, we should work with interface.
            var str = fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            //Create an object type with key and value.
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }



        public string GetUnprocessedVideosAsCsv(IVideoRepository videoRepo)
        {
            var videoIds = new List<int>();
            
            using (var context = new VideoContext())
            {
                //This is where we touch the external resource
                IEnumerable<Video> videos = videoRepo.GetVideo();



                foreach (var v in videos)
                    videoIds.Add(v.Id);

                return String.Join(",", videoIds);
            }
        }
    }


    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}