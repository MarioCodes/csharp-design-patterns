## Singleton pattern
Asegura que una clase tiene una única instancia y ofrece un punto de acceso global a la misma

*code example - how to use it!*
~~~ csharp
public class SingletonService
{
  // eager loading because this is thread-safe
  private static SingletonService uniqueInstance = new SingletonService();

  // private constructor so there can be no initialization outside this class
  private SingletonService() {}

  private static SingletonService GetInstance()
  {
    return uniqueInstance();
  }
}
~~~
