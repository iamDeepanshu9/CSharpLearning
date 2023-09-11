using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Console.Write("Enter F for Feet and I for Inch: ");
		char type = Convert.ToChar(Console.ReadLine());
		if(type == 'F'){
			Console.Write("Enter Feet Value : ");
		}else{
			Console.Write("Enter Inch Value : ");
		}
		
		double value = Convert.ToDouble(Console.ReadLine());
		
		double result = type == 'F' ? value * 30.48 : value * 2.54;
		
		Console.WriteLine("the result in cm is : " + result);
			
	}
}
