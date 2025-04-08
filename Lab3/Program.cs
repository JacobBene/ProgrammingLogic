namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //step 1
        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine(a > b); 
        Console.WriteLine(a < c);
        Console.WriteLine(a > c && a > b);
        Console.WriteLine(a > c || a > b);

        //step 2
        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining)
    
        Console.WriteLine("Take an umbrella!");
        else
        Console.WriteLine("You're good to go!");
         
        if (haveUmbrella)
        Console.WriteLine("Take an Umbrella!");
        else
        Console.WriteLine("You're good to go!");

        //step 3
        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age<5)
        Console.WriteLine("Ticket is free!");
        if (4<age)
        if (age<13)
        Console.WriteLine("Child ticket: $5");
        if (12<age)
        if (age<65)
        Console.WriteLine("Standard ticket: $10");
        if (age>64)
        Console.WriteLine("Senior ticket: $6");

        //step 4
        Console.WriteLine("Enter a day of the week: ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
  default:
    Console.WriteLine("Invalid day!");
    break;
}









         



    }
}
