using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp
{
    internal interface IContent
    {
        string Title { get; }
        int Length { get; }
    }
}
