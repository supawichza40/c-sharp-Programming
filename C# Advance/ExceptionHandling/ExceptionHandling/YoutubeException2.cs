using System;

namespace ExceptionHandling
{
    public class YoutubeException2 :Exception
    {
        //To create a constructor ctor and tab
        public YoutubeException2(string message,Exception innerException) :base(message, innerException)
        {

        }
    }
}