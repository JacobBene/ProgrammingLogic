using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        //step 1
        string[] seasons = new string[]{"Spring", "Summer", "Fall", "Winter"};

        foreach(string str in seasons) {
            Console.WriteLine("season: " + str);
        }

        //step 2
        try
        {
        string[] days = new string[8];
        days[1] = "Monday";
        days[2] = "Tuesday";
        days[3] = "Wednesday";
        days[4] = "Thursday";
        days[5] = "Friday";
        days[6] = "Saturday";
        days[7] = "Sunday";
        
        Console.WriteLine("Enter a number (1-7): ");
        int week = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("That day is: " +days[week]);
        }
        catch  (Exception )
        {
            Console.WriteLine("Invalid input.");
        }

        //step 3
        string[] book = new string[]{"The Stranger", "The Way of Kings", "A Study in Scarlet"};
        string[] author = new string[]{"Albert Camus", "Brandon Sanderson", "Arthur Conan Doyle"};

        for (int orderBook = 0; orderBook < book.Length; orderBook++)
        for (int orderAuth = 0; orderAuth < author.Length; orderAuth++)
            
        
            Console.WriteLine("book: " +book[orderBook]+ " by " +author[orderAuth]);
        

        //step 4
        int[] temperatures = {65, 72, 78, 70, 68};
        Array.Sort(temperatures);
        foreach (int temp in temperatures)
        Console.WriteLine("Sorted temperatures: " +temp);

        Console.WriteLine("Highest temperature: " +temperatures.Max());
        Console.WriteLine("Lowest temperature: " +temperatures.Min());

        //step 5
        int[] countdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdown);
        for (int count = 0; count < countdown.GetLength(0); count++)

        Console.WriteLine("Countdown: " +count);


        
        
}}
        
        
        
        
        
