## Proxy pattern
Establece un placeholder para otro objeto y controlar el acceso a éste objeto. 

*code example - how to use it*
~~~ csharp
// tenemos una clase que queremos controlar
public class GumballMachine : IGumballMachine
{
	// has internal state and its things... 
}
~~~

~~~ csharp
// proxy con el que controlamos el acceso. en este caso añadimos un report
public class GumballProxy : IGumballProxy
{
	public IGumballMachine _machine;
	
	public GumballProxy(IGumballMachine machine)
	{
		_machine = machine;
	}
	
	public void Report()
	{
		Console.WriteLine($"Gumball machine location {_machine.GetLocation()}");
		Console.WriteLine($"Gumball machine {_machine.GetCount()} gumballs left";
	}
}
~~~

### Remote Proxy pattern
Una variedad del proxy pattern. Actúa como un sustituto de otro objeto para controlar el acceso a él. Se usa para conectar y comunicarse con un objeto que se encuentra en una red diferente.  
Para el cliente es como si se comunicara con el objeto real, pero en realidad el proxy está haciendo un forward de la comunicación sobre la red. 
