<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Task<int> task1 = Task<int>.Factory.StartNew(() => 100*100);
	int i = task1.Result;
	Console.WriteLine(i);
	Task<Book> task2 = Task<Book>.Factory.StartNew(() =>
	   {
		   string s = ".NET";
		   int d = 40;
		   return new Book { name = s, price = d };
	   });
	Book book = task2.GetAwaiter().GetResult();
	Console.WriteLine(book.name);

}
public class Book{
	public string name;
	public int price;
	}

// Define other methods and classes here
