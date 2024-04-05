# Software architecture patterns - implemented in csharp

## Strategy pattern
Define una familia de algoritmos, encapsulando cada uno de ellos y los hace intercambiables en runtime (configuración), independientemente de los clientes que los utilizan.  
Útil para implementar distintas variaciones de comportamiento dentro de una clase. 
 
## Observer pattern
Define una relacion, de una a muchos, entre un sujeto con estado y sus observadores de manera que, cuando el sujeto cambia de estado, todos sus observadores son notificados y actualizados automáticamente.  
Útil para implementar sistemas de notificaciones distribuidas. 

## Decorator pattern
Permite añadir nuevas funcionalidades a objetos de forma dinámica sin modificar su estructura interna. Funciona mediante wrappers que agregan comportamientos antes o después de delegar llamadas al objeto original.  
Útil para extender las responsabilidades de los objetos y evitar profileración de subclases. 