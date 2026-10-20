using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
    internal class Movie : IContent
    {
        private readonly Video video;

        public Movie(Video video)
        {
            if (video == null)
            {
                throw new ArgumentNullException("video");
            }
            this.video = video;
        }
        public string Title => video.Title;

        public int Length => video.Length;
    }
}
