using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Для_отчёт_3
{
    public class Song
    {
        public string Path { get; set; }

        public string FileName { get; set; }
        public string Singer { get; set; }
        public string Track { get; set; }

        public Song (string path, string filename, string singer, string track)
        {
            this.FileName = filename;
            this.Path = path;
            this.Singer = singer;
            this.Track = track;

        }
    }
}
