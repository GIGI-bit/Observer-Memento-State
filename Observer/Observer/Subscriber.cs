using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subscriber : IVideoViewer
    {
        public Subscriber() { }

        public void Update(Video video)
        {
            Console.WriteLine("Subscriber updated");
        }
    }
}
