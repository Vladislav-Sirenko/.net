<Query Kind="Program" />

void Main()
{
	Exc ex = new Exc();
	ex.EmptyCatch();
	ex.Finally();
	ex.Throw();
	ex.ThrowEx();
}
public class Exc
{
	public void Finally()
	{
		try
		{
			throw new NullReferenceException();
		}
		catch (Exception ex)
		{
			throw new OutOfMemoryException();
		}
		finally
		{
			Console.WriteLine("Finally will execute anyway");
		}
	}
	public void Throw()
	{
		try
		{
			throw new NullReferenceException();
		}
		catch (Exception)
		{
			throw;
		}
		finally
		{
			Console.WriteLine("Finally will execute anyway");
		}
	}
	public void ThrowEx()
	{
		try
		{
			throw new NullReferenceException();
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			Console.WriteLine("Finally will execute anyway");
		}
	}
	public void EmptyCatch()
	{
		try
		{
			throw new NullReferenceException();
		}
		catch 
		{
			throw;
		}
		finally
		{
			Console.WriteLine("Finally will execute anyway");
		}
	}
}

// Define other methods and classes here