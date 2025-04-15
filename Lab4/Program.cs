using System.Formats.Tar;
using System.Globalization;
using System.Linq.Expressions;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        //step 1
        for (int loop = 1; loop < 11; loop++)
        Console.WriteLine(loop);
        //step 2
        for (int evenNum = 1; evenNum < 21; evenNum++)
        if (evenNum % 2 == 0)
        Console.WriteLine(evenNum);
        //step 3
        int countBack = 5;
        while (countBack > 0 )
        {Console.WriteLine(countBack);
        countBack--;
        }
        //step 4
        Console.WriteLine("Enter a number greater than 100:");
        int myNum = Convert.ToInt32(Console.ReadLine());
        do
        {Console.WriteLine("Enter a number greater than 100:");
        myNum = Convert.ToInt32(Console.ReadLine());}
        while (myNum < 101);
        //step 5
        int numTen = 10;
        while (numTen <= 1000)
        {Console.WriteLine(numTen);
        numTen+=10;}
        //step 6
        for (int tri = 1; tri <= 10; tri++)
        {
            for (int tri2 = 1; tri2 <= tri; tri2++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        
       
      
        
        
        
        
        
        
        
        
        
        
         }
}
