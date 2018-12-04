<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

 void Main()
{
	A a = new A();
	Task task = new Task(a.DoSomething);
	task.Start();
	task.ContinueWith(work => a.Method(5));	
	Console.WriteLine("thread continue executing");
	//task.Wait();
}

public class A
{
	public int Method(int n)
	{
		int result = 1;
		for (int i = 1; i <= n; i++)
		{
			result *= i;
		}
		Console.WriteLine(result);
		return result;
	}
	public void DoSomething()
	{
		Thread.Sleep(5000);
		Console.WriteLine("Delay");
		
	}
}
// Define other methods and classes here
