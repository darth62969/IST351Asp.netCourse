using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareTubeAuth.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string Content { get; set; }
        public string Video { get; set; }
        public DateTime DatePosted { get; set; } = DateTime.Now;

        public ApplicationUser ApplicationUser { get; set; }
    }
/*
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }

        public List<Post> Posts { get; set; }
    }*/
}
