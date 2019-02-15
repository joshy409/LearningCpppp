using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("encoding");
            Thread.Sleep(3000);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "video" };
            var videoEncoder = new VideoEncoder();
            videoEncoder.Encode(video);
        }
    }
}
