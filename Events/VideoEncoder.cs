﻿using System;
using System.Threading;

namespace Events
{

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class Video
    {
        public string Title { get; set; }
    }
    public class VideoEncoder
    {
        //1 - Define a delegate
        //2 - Define an event based on that delegate
        //3 - Raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event EventHandler<VideoEventArgs> VideoEncoded;



        public void Encode(Video video)
        {

            Console.WriteLine("encoding");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}
