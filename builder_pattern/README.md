## Builder pattern
Patrón creacional que permite construir objetos de una gran complejidad, paso a paso. Permite producir diferentes tipos y representaciones de un objeto usando el mismo código para todos, así como validar objetos de gran complejidad.  
El patrón organiza la construcción en una serie de pasos opcionales. No necesitas llamarlos todos, solo los que hagan falta para la configuración particular de ese objeto.  
Una pista para ver si renta implementarlo es si tenemos constructores interminables en código.  

* `Builder interface` declara los pasos de construccion comunes para todos los tipos
* `Builder class` dispone de diferentes pasos según lo que construyamos. Puede producir productos que no sigan la interfaz común. De él es de quien se obtiene el producto final. Permite la validación.  
* `Product` son los objetos resultantes. Los productos producidos por diferentes builders no pertenencen a la misma jerarquia o interfaz
* `Director` define el orden en el que llamar cada paso, para que puedas reutilizar configuraciones de productos

~~~ csharp
public class Car
{
	public string Make { get; set; }
	public string Model { get; set; }
	public int Year { get; set; }
}
~~~

~~~ csharp
public interface ICarBuilder
{
	public ICarBuilder WithMake(string make);
	public ICarBuilder WithModel(string model);
	public ICarBuilder WithYear(int year);
	public Car Build();
}
~~~

~~~ csharp
public class CarBuilder : ICarBuilder
{
	private Car _car = new Car();
	
	public ICarBuilder WithMake(string make)
	{
	    _car.Make = make;
	    return this;
	}
	
	public ICarBuilder WithModel(string model)
	{
	    _car.Model = model;
	    return this;
	}
	
	public ICarBuilder WithYear(int year)
	{
	    _car.Year = year;
	    return this;
	}
	
	public Car Build()
	{
	    // you can force required validation here
	    if(_car.Year < 1886)
	    {
	        throw new ArgumentException("Year must be 1886 or later.");
	    }
	
	    if(string.IsNullOrEmpty(_car.Make))
	    {
	        throw new ArgumentException("Make is required.");
	    }
	
	    return _car;
	}
}
~~~

~~~ csharp
/*
 * The final product is often retrieved from a builder
 * since the director isn't aware of concrete
 * builders and products
 */
public class CarDirector
{
	public Car ConstructSportsCar(ICarBuilder builder)
	{
		builder.WithMake("Porsche")
			   .WithModel("911")
			   .WithYear(2024);
		return builder.Build();
	}
}
~~~

~~~ csharp
// usage
ICarBuilder builder = new CarBuilder();
ICarDirector director = new CarDirector();
Car myCar = director.ConstructSportsCar(builder);
~~~
