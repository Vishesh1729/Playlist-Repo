using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PATA = ProjectA.Team1;
using PATB = ProjectA.Team2;

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
            int.TryParse(TRYPARSE, out result);
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

            switch (UserNumber)
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

            switch (CustomerChoice)
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
                default:
                    Console.WriteLine("Your Choice {0} is Invalid", CustomerChoice);
                    goto Retry;

            }
        Error:
            Console.WriteLine("Do you Want To Purchase More");
            Console.WriteLine("Yes or No");
            string CustomerDesicion = Console.ReadLine();

            switch (CustomerDesicion.ToUpper())
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
            Main3();
        }
        static void Main3()
        {
            string Userchoice = string.Empty;
            do
            {
                Console.Write("Please Enter a Number = ");
                int UserTarget = int.Parse(Console.ReadLine());

                int Start = 0;
                while (Start <= UserTarget)
                {
                    Console.WriteLine(Start);
                    Start = Start + 3;
                }

                //Do While

                Console.Write("Please Enter a Number = ");
                int UserTarget1 = int.Parse(Console.ReadLine());

                int Start1 = 0;
                while (Start1 <= UserTarget1)
                {
                    Console.WriteLine(Start1);
                    Start1 = Start1 + 3;
                }
                do
                {
                    Console.WriteLine("Do you want to Continue - Yes or No");
                    Userchoice = Console.ReadLine().ToUpper();
                    if (Userchoice != "YES" && Userchoice != "NO")
                    {
                        Console.WriteLine("Inavalid Choice, Please say Yes or No");
                    }
                } while (Userchoice != "YES" && Userchoice != "NO");

            } while (Userchoice == "YES");
            Console.ReadLine();
            LOOPS();
        }

        static void LOOPS()
        {
            //DIfference between FOREACH loop,FOR loop, WHILE loop
            int[] Number = new int[3];
            Number[0] = 91;
            Number[1] = 92;
            Number[2] = 93;

            //FOREACH LOOP
            foreach (int k in Number)
            {
                Console.WriteLine(k);
            }
            //for loop
            for (int j = 0; j < Number.Length; j++)
            {
                Console.WriteLine(Number[j]);
            }
            //while loop
            int i = 0;
            while (i < Number.Length)
            {
                Console.WriteLine(Number[i]);
                i++;
            }
            Console.ReadLine();
            INSTANT();

        }

        static void INSTANT()
        {
            Program p = new Program();
            p.Evennumber();//static is not written then this method is used
        }

        public void Evennumber()// static is not written then it is a Insatnt method
        {
            int i = 0;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
            Main4();

        }
        static void Main4()
        {

            Evennumber1();//static is written then this method is used
        }

        public static void Evennumber1()
        {
            int i = 0;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
            Console.ReadLine();
            Outparameter();
        }
        static void Outparameter()
        {
            int Sum = 0;
            int Product = 0;

            Calculator(9, 10, out Sum, out Product);
            Console.WriteLine("Total = {0} && Product = {1}", Sum, Product);
        }
        public static void Calculator(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
            Refparameter();

        }
         
        static void Refparameter()
        {
            int i = 0;
            Simplemethod(ref i);
            Console.WriteLine(i);

        }
        static void Simplemethod(ref int j)
        {
            j = 10;
            ParameterArrays();
        }

        static void ParameterArrays()
        {
            int[] Numbers = new int[4];
            Numbers[0] = 20;
            Numbers[1] = 30;
            Numbers[2] = 40;
            Numbers[3] = 50;
            
            ParamsArrays(Numbers);
            ParamsArrays(1, 2, 3, 4, 5);// this is method argument

        }
        public static void ParamsArrays(params int[] Numbers)
            //if any other parameter is there then Parameter array should be last one
            //MAin(int i, param int [] Numbers) Should br order
            //Only one parameter should be in method
        {
            Console.WriteLine("There are {0} element in Array", Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }

       public static void NAMESPACE()
        {
            ProjectA.Team1.ClassA.PROJECT1();// First Method Write Fully Qualified Name
            ProjectA.Team2.ClassB.PROJECT1();

            PATA.ClassA.PROJECT1();//Other way is to Make abbrevation with "using" in top
            PATB.ClassB.PROJECT1();

        }
    }

}

namespace ProjectA
{
    namespace Team1
    {
        class ClassA
        {
            public static void PROJECT1()
            {
                Console.WriteLine("Hey");
                
            }
        }
    }
    namespace Team2
    {
        class ClassB
        {
            public static void PROJECT1() //Make public to link with other class
            {
                Console.WriteLine("Hi");
                
            }
        }
    }
}
