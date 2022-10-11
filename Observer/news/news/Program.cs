using System;
using System.Threading;

namespace news
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsAggregator newsAggregator = new NewsAggregator();
            Reader gaziz = new Reader("Gaziz");
            Reader kaisar = new Reader("Kaisar");

            newsAggregator.Subscribe(gaziz);
            newsAggregator.Subscribe(kaisar);


            // LoremN genereates N random words
            newsAggregator.Notify(new News("Lorem12", "ultricies leo integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus"));
            Thread.Sleep(1000);
            newsAggregator.Notify(new News("Lorem25", "ornare suspendisse sed nisi lacus sed viverra tellus in hac habitasse platea dictumst vestibulum rhoncus est pellentesque elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus"));
            Thread.Sleep(1000);
            newsAggregator.Unsubscribe(kaisar);
            newsAggregator.Notify(new News("Lorem5", "sed viverra tellus in hac"));
        }
    }
}
