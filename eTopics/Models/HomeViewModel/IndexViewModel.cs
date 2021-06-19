﻿using eTopics.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList.Core;


namespace eTopics.Models.HomeViewModel
{
    public class IndexViewModel
    {
       public IPagedList<Post> Posts { get; set; }
        public string SearchString { get; set; }
        public int PageNumber { get; set; }

    }
}
