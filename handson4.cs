using System;
public class exercise15
{
	public static void Main()
	{
	    string str1;//declaration 
        char[] arr1;
        int l,i;//the l will be used to find the length which is int and i is used to find the position
        l=0;// initilization
        char ch;
        
        Console.Write("Input the string : ");// input the string to be changed.
        str1 = Console.ReadLine();//read the input as string and allocate in str1.
        l=str1.Length;//find the length of str1.
        arr1 = str1.ToCharArray(0, l); // Converts string into char array.
        Console.Write("\nAfter conversion, the string is : ");//the final line will be print
        for(i=0; i < l; i++)//it will check every char of a string by iteration
         {
          ch=arr1[i];
           if (Char.IsLower(ch)) // check whether the character is lowercase
              Console.Write(Char.ToUpper(ch)); // Converts lowercase character to uppercase.
              else
              Console.Write(Char.ToLower(ch)); // Converts uppercase character to lowercase.
        }
    Console.Write("\n\n"); //used to differ or print the final line after two lines of space   
   }
}