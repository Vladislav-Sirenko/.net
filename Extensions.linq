<Query Kind="Program" />

void Main()
{
	string world = "Hello world";
	List<int> list = new List<int>{1,2,3,4,5};
	list.DoSomething().ShowSomething();
	world.ToWordsList().ShowSomething();
}
public static class ListExtensions{
	public static void ShowSomething<T>(this List<T> items)
	{
		foreach(var item in items){
			Console.WriteLine(item);
		}
	}
	public static List<int> DoSomething(this List<int> items)
	{
		items.Add(100);
		return items;
	}
	
}
public static class StringExtensions{
	public static List<string> ToWordsList(this string str){
		string[] splitString = str.Split(' ');
		List<string> list = new List<string>();
		for (int i = 0; i <= splitString.Length-1; i++)
		{
			list.Add(splitString[i]);
		}
		return list;
	}
}
// Define other methods and classes here