<Query Kind="Program" />

void Main()
{
	A a =new A();
	a.Method(out int b);
	Console.WriteLine(b);	
	a.Method(b); 
	Console.WriteLine(b);
	a.RefMethod(ref b);
	Console.WriteLine(b);	
}
class A {
	public void Method(out int a){
		a = 1000;
	}
	
	public void Method(int a){
		//new int variable
		a+=100;
		Console.WriteLine("local variable = " + a);
		//a=null;
	}
	
	public void RefMethod(ref int a){
		a+=100;
	}
}
// Define other methods and classes here
