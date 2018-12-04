<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
A a = new A();
//	Task<int>. task1 = Task.Factory.StartNew(() =>a.FactorialAsync(6) );
//	Console.WriteLine("Execution thread continue working");
//	task1.Result;
 int v  = a.FactorialAsync(6).Result;
 int b = await a.FactorialAsync(5);
 Console.WriteLine(v);
 Console.WriteLine(b);
}
public class A
{



	 int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
			result *= i;
		}
		//Console.WriteLine(result);
		return result;
		
	}

	// определение асинхронного метода
	 public async Task<int> FactorialAsync(int n)
	{
		var k = await Task.Run(() => Factorial(n));
		return k;
	}
}