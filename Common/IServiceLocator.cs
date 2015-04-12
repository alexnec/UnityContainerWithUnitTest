namespace Common
{
    // Common service locator interface
    public interface IServiceLocator
    {
        T Get<T>();
    }
}
