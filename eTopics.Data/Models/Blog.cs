using System;
using System.Collections.Generic;
using System.Text;

namespace eTopics.Data.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public ApplicationUsers Creator { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Updatedon { get; set; }
        public bool Published { get; set; }
        public bool Approved { get; set; }
        public ApplicationUsers Approver { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
