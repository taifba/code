using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Welcome to my Multiplication Program");
        
		Console.WriteLine(Convert.ToInt32(Multiply(1.2, 1.5, Convert.ToInt32(3.4), Convert.ToInt32(7.2))));
	}
	static double Multiply(double num1 , double num2 , int num3 , int num4 ){
    
		 Convert.ToInt32(num1) ;
		 Convert.ToInt32(num2)  ;
		
		return num1 * num2 * num3 * num4 ;
  }
}
