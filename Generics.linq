<Query Kind="Program" />

void Main()
{
	B b = new B();
	b.Method<int>(11);
	b.Method("a");
}
public class Base<T> where T:class,A, new ()  {
A a;
public Base()
{
	a = new T();
}
public void Method<T> ()
where T:class , A, new () 
{
	
}
}
public interface A {}

public class B
{
	public void Method(string a){
		Console.WriteLine(a);
	}
	public void Method<T>(T a)
	{
		Console.WriteLine(a + "b");
	}
}
// Define other methods and classes here