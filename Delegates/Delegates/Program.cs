using System;

namespace Delegates
{
    class Program
    {

        static void Main(string[] args)

        {
            var media = new Media();
            var recordPlayer = new RecordPlayer();
            var videoPlayer = new VideoPlayer();



            Media.TestMedia testRecodDelegate = new Media.TestMedia(recordPlayer.Play);
            Media.TestMedia testVideoPlayer = new Media.TestMedia(videoPlayer.Play);

            media.Test(testRecodDelegate);

            media.Test(testVideoPlayer) ;
        }


    }


}
