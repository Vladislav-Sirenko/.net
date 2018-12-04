<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var task1 = Task.Run(() => { throw new NullReferenceException(); });

	try
	{
	task1.Wait();		
	}
	catch (AggregateException ex)
	{
		Console.WriteLine(ex);
		Console.WriteLine(ex.InnerException);
	}

}

// Define other methods and classes here
