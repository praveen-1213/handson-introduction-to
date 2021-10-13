using System;  
public class Exercise7  
{  
    public static void Main() 
{
    string str;
    int alp, digit, raj,i,l;
    alp = digit = raj=i = 0;


      Console.Write("Input the string : ");
      str = Console.ReadLine();	
      l=str.Length; 

     
    while(i<l)
    {
        if((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
        {
            alp++;
        }
        else if(str[i]>='0' && str[i]<='9') 
        {
            digit++;
        }
        else
        {
            raj++;
        }

        i++;
    }

   Console.Write("Number of Alphabets in the string is : {0}\n", alp);
   Console.Write("Number of Digits in the string is : {0}\n", digit);
   Console.Write("Number of Alphabets in the string is : {0}\n", raj);
 
	}
}