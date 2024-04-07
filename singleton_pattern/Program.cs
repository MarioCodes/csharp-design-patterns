using singletonService.service;

namespace template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // this doesn't compile as the constructor is private
            // SingletonService service = new SingletonService();

            var service = SingletonService.GetInstance();
        }

    }
}
