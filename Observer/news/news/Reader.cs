using System;

namespace news
{
    public sealed class Reader : IObserver<News>
    {
        public String Name { get; set; }

        public Reader(string name)
        {
            Name = name;
        }

        public void Update(News news)
        {
            Console.Write(Name + "\t=>");
            Console.WriteLine("\t" + news.Title);
            Console.WriteLine("\t\t" + news.Content);
            Console.WriteLine("-----------------------------------\n");
        }
    }
}
