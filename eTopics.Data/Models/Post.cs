using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTopics.Data.Models {
    public class Post {
        public int Id { get; set; }
        public ApplicationUsers Creator { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool Published { get; set; }

        public bool Approved { get; set; }
        public ApplicationUsers Approver { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }
    }
}