using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
    internal class StreamingPlatform
    {
        private List<IContent> contentList;
         public StreamingPlatform()
        {
            contentList = new List<IContent>();
        }

        public void AddContent(IContent content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }
            contentList.Add(content);
        }

        public IContent GetLongestContent()
        {
            if (contentList.Count == 0)
            {
                throw new InvalidOperationException("Nincs tartalom a platformon");
            }

            IContent longestContent = contentList[0];
            foreach (IContent content in contentList)
            {
                if (content.Length > longestContent.Length)
                {
                    longestContent = content;
                }
            }
            return longestContent;
        }

        public List<IContent> GetContents()
        {
            return contentList;
        }
    }
}
