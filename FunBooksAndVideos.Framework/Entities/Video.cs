using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class Video : Product
    {
        public override string ToString() => $"Video \"{Name}\"";
    }
}
