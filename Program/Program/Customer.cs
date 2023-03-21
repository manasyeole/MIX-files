//using System;

//namespace Program
//{
//    class Program
//    {
//        int n = 10;
//        public String user = "MERMEN";
//        private int sum = 999;

//        Program()
//        {
//            n = 100;
//            user = "MINTU";
//            sum = 777;
//            Console.WriteLine("This is default constructor");
//        }

//        Program(int num,String us,int finalsum)
//        {
//            n = num;
//            user = us;
//            sum = finalsum;
//            Console.WriteLine("This is parametrized  constructor");
//        }
//        public  void seemessage()
//        {
//            Console.WriteLine("This is call a direct function call");
//        }

//        static void Main(string[] args)
//        {
//            Program P = new Program();
//            Program Pk = new Program(100,"kiyu",899);
//            Program Pks = new Program(522, "hibre", 909);
//            //Test T = new Test();
//            Console.WriteLine(P.n + P.user + P.sum);
//            Console.WriteLine(Pk.n + Pk.user + Pk.sum);
//            Console.WriteLine(Pks.n + Pks.user + Pks.sum);
//            //Console.WriteLine(T.num + T.user + T.sum);



//        }

//    }
//}

////class Test
////{
////    public int num;
////    public String user = "kill";
////    public int sum;

////}

////using System;
////public class Student
////{
////    public int id;
////    public String name;
////    public static void Main(string[] args)
////    {
////        Student s1 = new Student();
////        s1.id = 101;
////        s1.name = "Sonoo Jaiswal";
////        Console.WriteLine(s1.id);
////        Console.WriteLine(s1.name);

////    }
////}
//class TestStudent
//{
//    //public static void Main(string[] args)
//    //{
//    //    Student s1 = new Student();
//    //    s1.id = 101;
//    //    s1.name = "Sonoo Jaiswal";
//    //    Console.WriteLine(s1.id);
//    //    Console.WriteLine(s1.name);

//    //}
//}



using System;

 public class Bank
{
    private string name; // field In the spirit of encapsulation, it is common to make fields private. 

    public string Bank_Name   // property The method that is used to set/modify the value of a private instance variable 
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }

    private int Bank_Id;
    public int Bank_ID
    { get; set; }

    private string Bank_location;
    public string Bank_Location
    { get; set; }


    //Constructor : default & parameterized
    // one class can have multiple constructor
    // It is used to initialize the data members of new object generally
    //You can prevent a class from being instantiated by making the constructor private

    //C# static constructor cannot have any modifier or parameter.
    //C# static constructor is invoked implicitly. It can't be called explicitly.

    //this -- keyword is used to refer to current instance , to assign parameter to field
    public Bank(String Bank_Name, int Bank_Id,String Bank_location) // 
    {
        this.Bank_Name = Bank_Name + "Banking System.PVT.Limited";
        this.Bank_Id = Bank_Id;
        this.Bank_location = Bank_location;
    }

    //Encapsulation is implemented by using access specifiers.
    //An access specifier defines the scope and visibility of a class member.

    //methods public methods :
    // private methods : 
    public void Bank_Details()
    {
        Console.WriteLine("Bank_Name" + Bank_Name);
        Console.WriteLine("Bank Location" + Bank_location);
        Console.WriteLine("Bank_Id" + Bank_Id);
    }

    public void show_InterestRate()
    {
        Console.WriteLine(CommonMethods_InBanks.Interest_rate + 2.3f);
    }
}

public class Customer : Bank
{
    private string cust_Name;
    public string Cust_Name { get; set; }

    private int Customer_Id;
    private long Money;
    private long Withdraw_limit;
    private long Balance;

    public Customer(string cust_Name, int Customer_Id)
    {
        this.cust_Name = cust_Name;
        this.Customer_Id = Customer_Id;
    }


    public void Deposit_Money(int fund)
    {
        Money += fund;
    }

    public void Withdraw_Money(int fund)
    {
        if (Balance < 1000)
        {
            Console.WriteLine("Balance IS less than Withdraw_Balance" + Balance);
        }
        else
        {
            Money -= fund;
        }
    }

    public void Calculate_balance(int Money)
    {
        Balance = Money;
    }
    public void Display_Balance()
    {
        Console.WriteLine("Display Balance " + Balance);

    }

    public void Display_AccountInformation()
    {
        Console.WriteLine("Customer Name" + Cust_Name);
        Console.WriteLine("Customer ID" + Customer_Id);
        Console.WriteLine("Bank Name" + base.Bank_Name);
        Console.WriteLine("Bank Location" + base.Bank_Location);
        Console.WriteLine("Withdraw Limit" + Withdraw_limit);

    }

}

//Static class eXAMPLE : C# static class contains only static members ,  cannot be instantiated , sealed class
// cannot contain instance constructors

public static class CommonMethods_InBanks
{
    public static float Interest_rate = 6.5f;
    public static string RBI_Approval = "Approved";
}

//Struct : Structure are Unlike class, structs in C# are value type than reference type.
// It is useful if you have data that is not intended to be modified after creation of struct.
// can have methods , contructors, datamembers
//Struct doesn't support inheritance. But it can implement interfaces.

public struct RBI_Guide
{
    public int helpline
    {
        get; set;
    }
    public RBI_Guide(int helpline)
    {
        this.helpline = helpline;
    }
    public void HelplineNumber()
    {
        Console.WriteLine("Helpline Number of RBI " + (helpline));
    }
}


//Testing class with Main Method
class TestSystem
{
    //public static void create_Account()
    //{
    //    long Balance = 0;
    //    Console.WriteLine("Enter Bank Name");
    //    string userName = Console.ReadLine();
    //}
    public static void Main()
    {
        Bank A = new Bank("Axis", 1001, "Delhi,India");
        A.Bank_Details();
        A.Bank_Name = "HDFC";
        Console.WriteLine(A.Bank_Name);
        A.Bank_ID = 1002;
        Console.WriteLine(A.Bank_ID);
        A.Bank_Location= "Pune,India";
        Console.WriteLine(A.Bank_Location);
        Bank B = new Bank("Bandhan", 1003, "Delhi,India");
        B.Bank_Details();

        A.show_InterestRate(); // static class called
        Console.WriteLine(CommonMethods_InBanks.Interest_rate);

        RBI_Guide RB = new RBI_Guide(10983883); // struct called
       Console.WriteLine(RB.helpline);
    }
}