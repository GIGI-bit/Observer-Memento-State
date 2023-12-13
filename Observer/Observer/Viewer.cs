using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Viewer : IVideoViewer
    {
        public Viewer()
        {
            
        }
        public void Update(Video video)
        {
            Console.WriteLine("Viewer Updated");
        }
    }
}
