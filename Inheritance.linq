<Query Kind="Program" />

void Main()
{
	Baseclass derived = new Derived();
	derived.Method();
}

public class Baseclass{
	public Baseclass()
	{
		Console.WriteLine("Default Base");		
	}
	public Baseclass(string a)
	{
		Console.WriteLine(a);
	}
	 public virtual void  Method(){
	 	Console.WriteLine("Base class");
	 }
}
public class Derived: Baseclass{
	public Derived():this("Call ctor with sting")
	{
		Console.WriteLine("Derived");
	}
	public Derived(string a):base("Call base not default nut don`t call default")
	{
		Console.WriteLine(a);
	}
	public override void Method(){
		base.Method();
		Console.WriteLine("Derived class");
	}
}