namespace ConditionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region If-else
            //byte age = 18;


            //if (age >= 18)
            //{
            //    Console.WriteLine("Xosh geldiz");
            //}
            //else if (age == 18)
            //{
            //    Console.WriteLine("Stajor olaraq goture bilerik");
            //}
            //else
            //{
            //    Console.WriteLine("Yashiniz uygun deyil");
            //}

            //string gender = "female";


            //if(age>=18 && gender == "female")
            //{
            //    Console.WriteLine("Xosh geldiz");
            //}
            //else
            //{
            //    Console.WriteLine("Uygun deyilsiz");
            //}










            //CTRL+k+c   CTRL+k+u
            //if (age >= 18)
            //{
            //    if (gender == "female")
            //    {
            //        Console.WriteLine("Xosh geldiz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Xanim ishci axtaririq");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Yashiniz uygun deyil");
            //}



            #endregion

            //CTRL + k + s
            #region Switch-Case

            //if (choice == 1)
            //{
            //    Console.WriteLine("Az dili secildi");
            //}
            //else if (choice == 2)
            //{
            //    Console.WriteLine("Rus dili sechildi");
            //}
            //else if (choice == 3)
            //{
            //    Console.WriteLine("Eng dili sechildi");
            //}


            //int choice = 20;

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Az dili secildi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Rus dili sechildi");
            //        break;
            //    case 3:
            //        Console.WriteLine("Eng dili sechildi");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong Input");
            //        break;

            //}


            //string day = "saturday";

            //switch (day)
            //{
            //    case "monday":  
            //    case "tuesday":  
            //    case "wednesday":
            //    case "thursday":
            //    case "friday":
            //        Console.WriteLine("Ish gunudur");
            //        break;
            //    case "saturday" or "sunday":
            //        Console.WriteLine("Qeyri ish gunudur");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong input");
            //        break;
            //}

            #endregion

            #region For loop
            //0 1  2 3 4 5 6 7 8 9 
            //for(int i=0; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //int count = 0;
            //int sum = 0;

            //for(int i = 0; i < 100; i++)
            //{

            //    if (i % 3 == 0)
            //    {
            //        sum += i;
            //        //Console.WriteLine(i);
            //        //count++; 
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(count);

            //for (int i=100;i>0;i--)
            //{
            //    Console.WriteLine(i);
            //}
            //bool result = false;

            //for (int i = 1; i < 100; i++)
            //{
            //    if(i%21==0)
            //    {
            //        result = true;
            //        break;
            //    }

            //}

            //if (result)
            //{
            //    Console.WriteLine("Var");
            //}
            //else
            //{
            //    Console.WriteLine("Yoxdur");
            //} 
            #endregion

            #region While Do-While

            //int num = 60;
            //int count = 0;
            //while (num%2==0)
            //{
            //    num /= 2;
            //    count++;
            //}

            //int num = 246;// 24  2 0
            ////int sum = 0;
            //int count = 0;
            //while (num!=0) 
            //{
            //    //sum += num % 10;
            //    num /= 10;
            //    count++;
            //}

            //do
            //{
            //    num /= 10;
            //    count++;
            //} while (num != 0);



            //Console.WriteLine(sum);
            //Console.WriteLine(count);

            #endregion

            #region Functions

            //PrintSum(5,10);


            //PrintSum(20, 10);



            //PrintDigit(123);

            //PrintDigit(45678);

            //PrintDigit(0);

            //    StringFormatHelper.PrintUpper("saLaM");
            //    StringFormatHelper.PrintLower("saLaM"); 
            #endregion

        }

        public static void PrintDigit(int num)
        {
            int count = 0;

            do
            {
                num/= 10;
                count++;
            }
            while (num != 0);
            Console.WriteLine(count);
        }


        public static void PrintSum(int num, int num2)
        {
            Console.WriteLine(num + num2);
        }
    }
}
