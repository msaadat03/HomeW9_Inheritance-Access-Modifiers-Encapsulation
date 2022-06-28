using System;

namespace Inheritance__Access_Modifiers_29._06._2020
//{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        ////1 СПОСОБ:  ededin faktorialinin hesablanmasi 
    //        //int n = 7; 
    //        //int factorial = 1; 
    //        //for (int i = 2; i <= n; i++)
    //        //{
    //        //    factorial = factorial * i; 
    //        //}
    //        //{
    //        //    Console.WriteLine(factorial); 
    //        //}       



    ////2 СПОСОБ:  ededin faktorialinin hesablanmasi
    //class Factor
    //{
    //    public int Fact(int n)
    //    {
    //        if (n == 0)
    //            return 0;
    //        if (n == 1)
    //            return 1;
    //        else
    //            return Fact(n - 1) * n;
    //    }
    //}

    //        class FactorResult
    //        {
    //            static void Main()
    //            {
    //                Factor i = new Factor();
    //                Console.WriteLine(i.Fact((7)));
    //            }
    //        }



    ////1 способ: Mail ve password gelir
    //string login = "cavid@code.edu.az";
    //string password = "12345";
    //{
    //    Console.WriteLine("Email daxil edin");
    //    string Login = Console.ReadLine();


    //    Console.WriteLine("Şifre daxil edin");
    //    string Password = Console.ReadLine();

    //    if (login == Login && password == Password)
    //    {
    //        Console.WriteLine("Girish olundu");
    //        Console.ReadLine();
    //    }
    //    else
    //    {
    //        Console.WriteLine("Mail ve yaxud password sehvdir");
    //        Console.ReadLine();
    //    }

    //}


    //////2 способ: Mail ve password gelir
    //public class Cheking
    //{
    //    public static int GmailPassword(string login, string password)
    //    {
    //        string Login = "cavid@code.edu.az";
    //        string Password = "12345";

    //        if (login == Login && password == Password)
    //        {
    //            Console.WriteLine("Girish olundu");
    //            return -1;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Login ve yaxud password sehvdir");
    //            return -1;
    //        }
    //    }



    //    public class ChekingGmailPassword
    //    {
    //        public static void Main(string[] args)
    //        {
    //            Cheking Value = new Cheking();
    //            Cheking.GmailPassword("cavid@code.edu.az", "12345");


    //}


    ////3 способ: Mail ve password gelir (bunu denedeim elemeye lakin alinmadi)
//    class Program
//    {
//        public static void LoginAndPassword(out string login, out string password)
//        {
          
//            string Login = "cavid@code.edu.az";
//            string Password = "12345";

//            if (login == Login && password == Password)
//            {
//                Console.WriteLine("Girish olundu");
//            }
//            else
//            {
//                Console.WriteLine("Mail ve yaxud password sehvdir");
//            }

//        }


//        class Mein
//        {
//            public static void LoginAndPassword(string login, string password)
//            {
//                Console.Write("Email daxil edin");
//                login = Console.ReadLine();

//                Console.Write("Şifre daxil edin");
//                password = Console.ReadLine();

//                Program Value = new Program();
//                Program.LoginAndPassword() ;
//            }
//        }
//    }
//}









