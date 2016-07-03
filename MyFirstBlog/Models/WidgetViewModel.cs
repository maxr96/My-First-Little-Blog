﻿using MyFirstBlog.Core;
using MyFirstBlog.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstBlog.Models
{
    public class WidgetViewModel
    {
        public WidgetViewModel(IBlogRepository blogRepository)
        {
            Categories = blogRepository.Categories();
            Tags = blogRepository.Tags();
            LatestPosts = blogRepository.Posts(0, 10);
        }

        public IList<Category> Categories { get; private set; }
        public IList<Tag> Tags { get; private set; }
        public IList<Post> LatestPosts { get; private set; }
    }
}