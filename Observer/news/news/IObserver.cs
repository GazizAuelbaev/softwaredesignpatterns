namespace news
{
    public interface IObserver<T>
    {
        void Update(T data);
    }
}
