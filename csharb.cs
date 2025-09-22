// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      Console.Write ("Enter number : ");
      int  x = Convert.ToInt32(Console.ReadLine());
    
        
            Console.Write ("Enter number : ");
            int  y = Convert.ToInt32(Console.ReadLine());
            if (x>y){
                Console.Write ($"{x} number greater than {y} number");
            }else if(x<y){
                Console.WriteLine ($"{y} number greater than {x} number");
            }
            else if(x==y){
                Console.WriteLine($"{x} is equal {y}");
            }
            else{
                Console.WriteLine ("Something was wrong");
            }
            
            
                
            
        }
        
      
    }


