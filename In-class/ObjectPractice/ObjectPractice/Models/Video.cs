using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectPractice.Models
{
    public class Video
    {
        public string link { get; set; }

    }
    public class VideoContext : DbContext
    {
        public VideoContext (DbContextOptions<VideoContext> options)
            : base(options)
        {

        }
    }
}

