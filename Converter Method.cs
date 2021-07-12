using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(ConvertMyDataType(2.5));
	}
	static int ConvertMyDataType(double num ){
    
		return  Convert.ToInt32(num)  ;
  }
}
