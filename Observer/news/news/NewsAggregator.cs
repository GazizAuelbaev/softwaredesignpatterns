using System;
using System.Collections.Generic;

namespace news
{
    public sealed class NewsAggregator : IObservable<News>
    {
        private readonly List<IObserver<News>> observers;

        public NewsAggregator()
        {
            observers = new List<IObserver<News>>();
        }

        public void Notify(News data)
        {
            foreach(IObserver<News> observer in observers)
            {
                observer.Update(data);
            }
        }

        public void Subscribe(IObserver<News> observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver<News> observer)
        {
            observers.Remove(observer);
        }
    }
}
