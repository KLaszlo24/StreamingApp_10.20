using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
    internal class Series : IContent
    {
        private List<Video>episodes;
        public string Title { get; private set; }
        public int Length
        {
            get
            {
                int totalLength = 0;
                foreach (Video video in episodes)
                {
                    totalLength += video.Length;
                }
                return totalLength;
            }
        }

        public Series(string title, Video elsovideo)
        {
            Title = title;
            episodes = new List<Video>();
            episodes.Add(elsovideo);
        }

        public Series(string title, List<Video> videoList)
        {
            Title = title;
            episodes = videoList;
        }
    }
}
