namespace GenericBuilder.Builder
{
    public class Builder
    {
        public static T Create<T>(Action<T>? perform = null) where T : new()
        {
            var instance = new T();
            perform?.Invoke(instance);
            return instance;
        }
    }
}
