<Query Kind="Program" />

public class Animal{
public Animal(){
Console.WriteLine("This is animal");

}
public void Sing(){
Console.WriteLine("This is animal sing");
}
public virtual void Bark(){
Console.WriteLine("This is animal bark");
}
public void eat(){
Console.WriteLine("This is animal eat");
}
}
public class Dog : Animal{
public Dog(){
Console.WriteLine("This is dog");
}
public new void Sing(){
Console.WriteLine("This is dog sing");
}
public override void Bark(){
Console.WriteLine("This is dog bark");
}
}
void Main()
{

Animal dog = new Dog();
dog.Bark();
dog.Sing();
dog.eat();
Dog ndog= new Dog();
ndog.Sing();
}

// Define other methods and classes here