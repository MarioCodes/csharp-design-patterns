# Software architecture patterns - implemented in csharp

*(disclaimer: all this info is for personal use and comes from my understanding from the book [Head First Design Patterns](https://www.oreilly.com/library/view/head-first-design/0596007124/). For more info or details please purchase the book to support the original authors)*

## Design principles  
* Identify the aspects of your application that vary and separate them from what stays the same
* Program to an interface, not an implementation
* Favor composition over inheritance -> has-a may be better than is-a
* Strive for loosely coupled designs between objects that interact
* Classes should be open for extension, but closed for modification

## Strategy pattern
Define una familia de algoritmos, encapsulando cada uno de ellos y los hace intercambiables en runtime (configuración), independientemente de los clientes que los utilizan.  
Útil para cambiar algoritmos en tiempo de ejecución y elegir la estrategia más adecuada según el contexto. 

![strategy pattern class diagram](_images/strategy_pattern.drawio.png)

*code example - how to use it!*
~~~ csharp
Duck duck = new MallardDuck(new Quack(), new FlyNoWay());
duck.PerformQuack(); // quacks like a duck
duck.PerformFly(); // cannot fly
duck.Display(); // looks like a MallardDuck

Duck duck2 = new MallardDuck(new MuteQuack(), new FlyWithWings());
duck2.PerformQuack(); // <<silence>>
duck2.PerformFly(); // flying with wings
duck2.Display(); // looks like a MallardDuck

Duck duck3 = new RedheadDuck(new Squak(), new FlyWithWings());
duck3.PerformQuack(); // squeaks
duck3.PerformFly(); // flying with wings
duck3.Display(); // looks like a Redhead Duck
~~~

## Observer pattern
Define una relacion, de una a muchos, entre un sujeto con estado y sus observadores de manera que, cuando el sujeto cambia de estado, todos sus observadores son notificados y actualizados automáticamente.  

Facilita la notificación de cambios en un objeto a múltiples observadores. 

![observer pattern class diagram](_images/observer_pattern.drawio.png)

*code example - how to use it!*
~~~ csharp
WeatherData weatherData = new WeatherData();
DisplayElement currentDisplay = new CurrentConditionsDisplay(weatherData);
DisplayElement forecastDisplay = new ForecastDisplay(weatherData);

// SetMeasurements() calls NotifyObservers() and this calls Update() for all observers
// on Update() it calls Display() to see the change. this prints:
weatherData.SetMeasurements(80, 65, 30.4f);
//   currentConditionsDisplay: temp 80, humidity 65%
//   forecast display based on pressure: temp 80, humidity 65%

weatherData.SetMeasurements(40, 25, 28.5f);
//   currentConditionsDisplay: temp 40, humidity 25%
//   forecast display based on pressure: temp 40, humidity 25%
~~~

## Decorator pattern
Permite añadir nuevas funcionalidades o responsabilidades a objetos de forma dinámica sin modificar su estructura interna. Funciona mediante wrappers que agregan comportamientos antes o después de delegar llamadas al objeto original.  

![decorator pattern class diagram](_images/decorator_pattern.drawio.png)

*code example - how to use it!*
~~~ csharp
Beverage beberage = new Espresso();
Console.WriteLine($"{beverage.Description} {beverage.Cost()}");
// Espresso $1,99

Beverage2 = new DarkRoast();
beverage2 = new Mocha(beverage2);
Console.WriteLine($"{beverage2.Description} {beverage2.Cost()}");
// Dark roast, Mocha $1,45

Beverage3 = new HouseBlend();
beverage3 = new Soy(beverage3);
beverage3 = new Mocha(beverage3);
beverage3 = new Whip(beverage3);
Console.WriteLine($"{beverage3.Description} {beverage3.Cost()}");
// House blend coffee, Soy, Mocha, Whip $1,74
~~~

## Factory pattern
Define una interfaz para crear un objeto, pero deja a las subclases decidir que clase instanciar. Permite a una clase diferir la instanciación a sus subclases. 
Útil para cuando se trabaja con familias de objetos relacionados y se desea que todos los objetos que tienen que cooperar entre sí, provengan de la misma familia o tipo.  
Permite utilizar diferentes implementaciones para diferentes situaciones.  

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
