using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Youtuber
    {
        public string NickName;
        public List<Video> videos;
        public List<IVideoViewer> viewers;
        public Youtuber() { }
        public void publishVideo() { Console.WriteLine("Video Published"); }
    }
}
