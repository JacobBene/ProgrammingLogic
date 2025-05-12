namespace Lab8;

class Animal 
{
public virtual void animalSound()
    {
     Console.WriteLine("The animal makes a sound.");
    }
}

class Cat : Animal
{
  public override void animalSound() 
  {
    Console.WriteLine("The cat says: meow");
  }
}
class Dog : Animal
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}
class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myCat = new Cat();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myCat.animalSound();
    myDog.animalSound();
  }
}





