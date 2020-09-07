using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
         static void Main(string[] args)
          //Datatype Conversion
         {
             int i = 100;
             float f = i;
             Console.WriteLine(f);
             float g = 100282821234222.43F;
             int h = (int)g;

             Console.WriteLine(h);

              //Parse and Try Parse
             string s = "100";
             int V = int.Parse(s);
             Console.WriteLine(V);

             string TRYPARSE = "100AV";
             int result = 0;
             int.TryParse(TRYPARSE, out result );
             Console.WriteLine(TRYPARSE);
             Main1();
         }
        static void Main1()
        // Arrays
        {
            int[] Evennumbers = new int[5];

            Evennumbers[0] = 0;
            Evennumbers[1] = 2;
            Evennumbers[2] = 4;
            Evennumbers[3] = 6;
            Evennumbers[4] = 8;


            Console.WriteLine(Evennumbers[4]);
            Main2();
        }

        static void Main2()
        //IF STATEMENT
        {
              Console.Write("Please Enter Number = ");
              int Usernumber = Convert.ToInt32(Console.ReadLine());

              if (Usernumber == 1)
              {
                  Console.WriteLine("Your Number is 1");
              }
             else if (Usernumber == 2)
              {
                  Console.WriteLine("Your Number is 2");
              }
              else if (Usernumber == 3)
              {
                  Console.WriteLine("Your Number is 3");
              }
              else 
              {
                  Console.WriteLine("YOUR NUMBER IS NOT IN 1 TO 3");
              }

              //Switch Statement

              Console.Write("Please Enter A Number = ");
              int UserNumber = Convert.ToInt32(Console.ReadLine());    

              switch(UserNumber)
              {
                  case 1:
                      Console.WriteLine("Your Number is 1");
                      break;
                  case 2:
                      Console.WriteLine("Your Number is 2");
                      break;
                  case 3:
                      Console.WriteLine("Your Number is 3");
                      break;
                  case 4:
                      Console.WriteLine("Your Number is 4");
                      break;
                  default:
                      Console.WriteLine("Your Number is not 1,2,3,4");
                      break;
              }
            //Program With Switch statement
            // ICE CREAM Shop Programming with Switch and Goto 

            int TotalIcecreamCost = 0;
            Retry:
            Console.WriteLine("Please Select Coffee Flavour From Menu");
            Console.WriteLine("1 Chocolate");
            Console.WriteLine("2 Vanilla");
            Console.WriteLine("3 Rajbhog");
            string CustomerChoice = Console.ReadLine();

            switch(CustomerChoice)
            {
                case "1":
                    TotalIcecreamCost += 30;
                    break;
                case "2":
                    TotalIcecreamCost += 20;
                    break;
                case "3":
                    TotalIcecreamCost += 40;
                    break;
                default :
                    Console.WriteLine("Your Choice {0} is Invalid", CustomerChoice);
                    goto Retry;
                    
            }
            Error:
            Console.WriteLine("Do you Want To Purchase More");
            Console.WriteLine("Yes or No");
            string CustomerDesicion = Console.ReadLine();

            switch(CustomerDesicion.ToUpper())
            {
                case "YES"://while converting to upper case (yes) should be in upper case and vice versa
                    goto Retry;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", CustomerDesicion);
                    goto Error;
            }


            Console.WriteLine("Bill amount = {0}", TotalIcecreamCost);
            Console.WriteLine("Thanks For Shopping ");
        }

        
    }
}
