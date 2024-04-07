namespace singletonService.service
{
    public class SingletonService
    {
        private static SingletonService uniqueInstance = new SingletonService();

        // private so there's no 'new'
        private SingletonService() {}

        public static SingletonService GetInstance()
        {
            return uniqueInstance;
        }

    }
}
