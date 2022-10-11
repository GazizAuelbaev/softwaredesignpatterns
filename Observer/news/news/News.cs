using System;

namespace news
{
    public sealed class News
    {
        public String Title { get; }
        public String Content { get; }

        public News(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
