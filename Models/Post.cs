using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInClone.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title  { get; set; }
        public string? Description { get; set; }
        public User Author { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
