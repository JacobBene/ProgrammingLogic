using System.Net.Security;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //step 1

        int myNum1 = 1;
        double myDouble1 = 1.11;
        float myFloat1 = 2.22F;
        char myChar1 = 'A';
        bool myBool1 = true;
        string myString1 = "Hello!";

        Console.WriteLine(myNum1);
        Console.WriteLine(myDouble1);
        Console.WriteLine(myFloat1);
        Console.WriteLine(myChar1);
        Console.WriteLine(myBool1);
        Console.WriteLine(myString1);

        //Step 2

        double myDouble2 = 9.78;
        int double2int = (int) myDouble2;
    
        Console.WriteLine("double:"+double2int);
        Console.WriteLine("int:"+Convert.ToString(myNum1));
        Console.WriteLine("bool:"+Convert.ToString(myBool1));

        //step 3

        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello " +age+ " year old named " + name + "!");
        
        //step 4

        int num1 = 10;
        int num2 = 20;

        int sum1 = num1+10;
        int sum2 = num2-2;
        int sum3 = num1*3;
        int sum4 = num2/2;
        int sum5 = num1%2;
         
        Console.WriteLine (num1+ " + 10 = " +sum1);
        Console.WriteLine (num2+ " - 2 = " +sum2);
        Console.WriteLine (num1+ " * 3 = " +sum3);
        Console.WriteLine (num2+ " / 2 = " +sum4);
        Console.WriteLine ("The division remainder of " +num1+ " is " +sum5);

        //step 5

        double myDouble3 = 1.123456789;
        float myFloat2 = 1.123456789F;

        Console.WriteLine (myDouble3);
        Console.WriteLine (myFloat2);

        //step 6

        int incrementVariable = 10;

        incrementVariable ++;

        Console.WriteLine (incrementVariable);

        incrementVariable --;

        Console.WriteLine (incrementVariable);


        
    }
}
