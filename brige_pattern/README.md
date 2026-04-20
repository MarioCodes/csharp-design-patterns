## Bridge pattern
Patron estructural que **permite desacoplar la abstracción de su implementación** para que ambas puedan variar de manera independiente. **Se utiliza para evitar explosión de clases** en sistemas con múltiples combinaciones de abstracciones e implementaciones. 

Para el caso que tengamos una *clase abstracta* `Shape` con dos formas `Circle` y `Square`, y una *interfaz* `Color` con dos colores `Red` y `Blue` nos salen las siguientes implementaciones.

*esto crece exponencialmente según añadimos formas y colores*
~~~
RedCircle
RedSquare
BlueCircle
BlueSquare
~~~

*la solución es que la clase abstracta CONTENGA la interfaz dentro de ella*  
*tenemos las interfaces de color por un lado*
~~~ csharp
public interface IColor
{
  void ApplyColor();
}

public class RedColor: IColor
{
  public void ApplyColor()
  {
    Console.WriteLine("Applying Red Color");
  }
}

public class BlueColor: IColor
{
  public void ApplyColor()
  {
    Console.WriteLine("Applying Blue Color");
  }
}
~~~

*la abstraccion de forma por otro*
~~~ csharp
public abstract class Shape
{
  // cada forma CONTIENE su color
  protected IColor color;
  
  protected Shape(IColor color)
  {
    this.color = color;
  }
  
  public abstract void Draw();
}

public class Circle : Shape
{
  public Circle(IColor color) : base(color) {}
  
  public override void Draw()
  {
    Console.WriteLine("Drawing Circle");
    // y deriva su llamada al color
    color.ApplyColor();
  }
}

public class Square : Shape
{
  public Square(IColor color) : base(color) {}
  
  public override void Draw()
  {
    Console.WriteLine("Drawing Circle");
    color.ApplyColor();
  }
}
~~~

*esto evita la proliferación de clases*
~~~ csharp
Shape redCircle = new Circle(new RedColor());
redCircle.Draw();

Shape blueSquare = new Square(new BlueColor());
blueSquare.Draw();
~~~
