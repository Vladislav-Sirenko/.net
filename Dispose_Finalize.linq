<Query Kind="Program" />

void Main()
{
	A a=null;
	try {
		a= new A();
	}
	finally{
		a.Dispose();
	}
	using (A b = new A()){
		
	}
}

public class A : IDisposable
{
	 bool disposed = false;
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
	protected virtual void Dispose(bool disposing)
	{
		if (disposed)
			return;

		if (disposing)
		{
			
			 
		}
		disposed = true;
	}
~A()
	{
		Dispose(false);
	}
}
// Define other methods and classes here