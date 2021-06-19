using System;
using System.Collections.Generic;

namespace eTopics.Data.Models {
    public class Comment {
        public int Id { get; set; }

        public Post Post { get; set; }
        public ApplicationUsers Author { get; set; }
        public string Content { get; set; }
        public Comment Parent { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
    }
}