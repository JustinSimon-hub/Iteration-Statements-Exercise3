namespace IterationStatements
{
    public class Program
    {






  //Method 1: Write all numbers from 1000 to -1000
        
 static void NumberPrinter()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        

//Method 2: Print numbers 3 through 999 by multiples of 3
 static void PrintByThree()
        {
            for (int z = 3; z <= 999; z+=3)
             {
                  Console.WriteLine(z);
            }

        }

//Method 3: Write a method that will take 2 integers as input and check whether they are equal to one another



static void NumberChecker (string a, string b)
        {
             bool f = int.TryParse(a, out int l);
             bool q = int.TryParse(b, out int p);
             if ( p == l )
                 {
                       Console.WriteLine("The numbers you entered match each other.");

                 }
                      else 
                 {
                          Console.WriteLine("The numbers you enterd dont match each other?");
                 }          
        } 





//Method 4: Checks even or odd

 static void EvenOdd (int x)
         {   
   
            int n = 2;
             {

                  if (n % x != 0)
                  {
                        Console.WriteLine("The number is even");
                  }
                         else 
                 {
                          Console.WriteLine("The number is odd");
                 }

                 }  
         } 
    


// Method 5 : Checks positive or negative if fails, make the access mod public 
 static void PosOrNeg (int a)
        {

               if ( a > 0)
                {
                     Console.WriteLine("This number is positive.");
                }
                     else if ( a < 0)
                 {
                        Console.WriteLine("This number is negative");
                }

        }




//  Method 6: Interpret the user age and determine if they can vote 
 static void Userage (string l)
            {
                 bool a = int.TryParse( l , out int y);
                      if ( y >= 18)
                  {
        
                         Console.WriteLine("You are old enough to vote.");
                  }
                 else if ( y < 18 )
                {
        
                     Console.WriteLine("You are not old enough to vote.");

                 }
    
    
            }


//Method 7: Checks if the user's numbers are within the range of -10 and 10 
 static void RangeChecker ( string z)
            {
                 bool q = int.TryParse( z, out int w );
                 if ( w <= 10 && w >= -10)
            {
                 Console.WriteLine("The number you selected is in range.");
            }
                else 
             {
                 Console.WriteLine("The number you entered is not in range.");
            }
            }       



      
      //Prints the user's entered number is a multiplication table up to factors of 12
static void TimesTable ( string k)
            {
    
                int i;
                bool u = int.TryParse(k, out  i);
    
                for ( int q = 0; 13 >= q && q >= 0; q++)
            {
                  int answer = q * i;
                  Console.WriteLine($"{q} times {i} is {answer}");
             }
            }


      static void Main(string[] args)
        {

         NumberPrinter();
           
        PrintByThree();
         
      Console.WriteLine("What two numbers do you want to check?");
        NumberChecker(Console.ReadLine(), Console.ReadLine());
          
          
        EvenOdd(5);
         PosOrNeg(6);
         
         Console.WriteLine("How old are you");
        Userage(Console.ReadLine());
       
       
       Console.WriteLine("Enter a number you would like to check.");
        RangeChecker(Console.ReadLine());
           
           Console.WriteLine("What number would you like a times table for?");
           TimesTable(Console.ReadLine());

        }
    }
    }

