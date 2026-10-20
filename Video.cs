using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
    internal class Video
    {
        public string Title { get; }
        public int Length { get; }

        public Video(string title, int length)
        {
            Title = title;
            Length = length;

            if (string.IsNullOrWhiteSpace(title)){
                throw new ArgumentException("A cím nem lehet üres");
            }

            if (length <= 0)
            {
                throw new ArgumentException("A hossz nem lehet nulla vagy negatív");
            }
    }
}
