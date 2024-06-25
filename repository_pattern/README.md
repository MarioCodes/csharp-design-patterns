# Repository Pattern (abstract) for ORM and override

*(to review and implement)*



Architectural design pattern used to separate data access and bussiness layers.  
This patterns acts as a middle layer. It provides an interface to perform CRUD operations on data entities while it maintains encapsulation. 
This pattern makes easier to test or change databases implementations. 

Base class
~~~ csharp
public class Producto
{
	[Key]
	public int Id { get; set; }

	[Required(ErrorMessage = "Name is required")]
	public string Name { get; set; }

	public string Description { get; set; }

	public string ImageUrl { get; set; }
}
~~~

Interface that defines all operations
~~~ csharp
public interface IRepository<T>
{
	T GetById(int id);
	IEnumerable<T> GetAll();
	void Add(T entity);
	void Update(T entity);
	void Delete(T entity);
}
~~~

Then we have the class which implements the interface. I mark them `virtual` to be able to override them if needed. 
~~~ csharp
public class Repository<T> : IRepository<T> where T : class
{
	private readonly ApplicationDbContext _context;
	private readonly DbSet<T> _dbSet;

	public Repository(ApplicationDbContext context)
	{
		_context = context;
		_dbSet = _context.Set<T>();
	}

	public virtual T GetById(int id)
	{
		return _dbSet.Find(id);
	}

	public virtual IEnumerable<T> GetAll()
	{
		return _dbSet.ToList();
	}

	public virtual void Add(T entity)
	{
		_dbSet.Add(entity);
		_context.SaveChanges();
	}

	public virtual void Update(T entity)
	{
		_context.Entry(entity).State = EntityState.Modified;
		_context.SaveChanges();
	}

	public virtual void Delete(T entity)
	{
		_dbSet.Remove(entity);
		_context.SaveChanges();
	}
}
~~~

To use this class, we use it through dependency injection
~~~ csharp
public class ProductoService
{
	private readonly IRepository<Producto> _productoRepository;

	public ProductoService(IRepository<Producto> productoRepository)
	{
		_productoRepository = productoRepository;
	}
}
~~~

Then at `Startup` class we define it for dependency injection
~~~ csharp
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
~~~

## Extend and override repository pattern
Let's imagine I have a more complicated version of `Producto` which has foreign key relations with the classes `Categoria` and `Aplicacion` where I need to override and adapt some methods from my `Repository`

Base class now
~~~ csharp
public class ProductoExtended 
{
	[Key]
	public int Id { get; set; }

	[Required(ErrorMessage = "Name is required")]
	public string Name { get; set; }

	public string Description { get; set; }

	public string ImageUrl { get; set; }

	// foreign keys - new!!
	public int CategoriaId { get; set; }
	
	[ForeignKey("CategoriaId")]
	public virtual Categoria? categoria { get; set; }
	
	public int AplicacionId { get; set; }
	
	[ForeignKey("AplicacionId")]
	public virtual Aplicacion? aplicacion { get; set; }
}
~~~

I'm going to create a new `interface` which implements `IRepository` with my new class `ProductoExtended` to be able to use dependency injection.

new interface 
~~~ csharp
public interface IProductoExtendedRepository : IRepository<ProductoExtended> { }
~~~

Then I create the implementation, which is going to extend the base `Repository` class to be able to override it and also use its other method implementations. 

interface implementation
~~~ csharp
public class ProductoExtendedRepository : Repository<ProductoExtended>, IProductoExtendedRepository
{

	private readonly ApplicationDbContext _context;
	private readonly DbSet<ProductoExtended> _dbSet;

	public ProductoExtendedRepository(ApplicationDbContext context) : base(context)
	{
		_context = context;
		_dbSet = _context.Set<ProductoExtended>();
	}

	public override IEnumerable<ProductoExtended> GetAll()
	{
		// this get method also returns Categoria and Aplicacion in case its needed
		return _context.ProductoExtended
			.Include(categoria => categoria.categoria)
			.Include(app => app.aplicacion);
	}

}
~~~

dependency injection at `Program`
~~~ csharp
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IProductoExtendedRepository, ProductoExtendedRepository>();
~~~

## Reference(s)
[https://medium.com/@kerimkkara/implementing-the-repository-pattern-in-c-and-net-5fdd91950485](https://medium.com/@kerimkkara/implementing-the-repository-pattern-in-c-and-net-5fdd91950485)

