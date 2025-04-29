namespace Lab6;

using System;
using Microsoft.VisualBasic;

class Car
{
  public string model;
  public string color;
  public int year;
//problem 1
public string start;

public int drive; 

public string repaint;


public string getDescription (string year, string color, string model) 
{
  return $"{year}{color}{model}";
}





  // Example method to display car details. You can use this as an example for the other methods.
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
    //problem 1
    Console.WriteLine("Start: " + start);
    Console.WriteLine("The car drove " +drive+ " miles.");
    Console.WriteLine("The car has been repainted to " +repaint);
    
    
    
    
    
    


  }
}

class Program

{
  static void Main()
  
  {
    
    
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;
    //problem 1
    myCar.start = "The car is starting.";
    //problem 2
    myCar.drive = 50; 
    //problem 3
    string newStr = myCar.getDescription("2020"," black"," civic");
    Console.WriteLine(newStr);
    // problem 4
    myCar.repaint = "red";
    
    
    

    myCar.Display(); // Calling the Display method



    

    
    
  }
}
    

