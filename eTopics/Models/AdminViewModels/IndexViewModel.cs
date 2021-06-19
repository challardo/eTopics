using eTopics.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTopics.Models.AdminViewModels
{
    public class IndexViewModel
    {
        //Dashboard view model
        public IEnumerable<Post> Posts { get; set; }
    }
}
