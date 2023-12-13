using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Video
    {
        private string title;
        private string description;

        public Video() { }

        public string Title { get=>title; set=> title=value; }
        public string Description { get=>description; set=>description=value; }

    }
}
