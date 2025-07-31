
using polymorephism;
using classObjects;
using encapsulations;
using inheritance;
using abstraction;
namespace oops;

class Program
{
    static void Main(string[] args)
    {
        // Class & Objects
        System.Console.WriteLine("Classes & Objects");
        Car myCar = new Car();
        myCar.Color = "Red";
        myCar.Drive();

        // Encapsulation
        System.Console.WriteLine("\nEncapsulation");
        Account myAccount = new Account();
        myAccount.SetBalance(1000);
        double balance = myAccount.GetBalance();
        System.Console.WriteLine(balance);

        // Inheritance
        System.Console.WriteLine("\nInheritance");
        Dog dog = new Dog();
        dog.Eat(); // Inherited from Animal
        dog.Bark(); // Own method

        // Polymorphism
        System.Console.WriteLine("\nPolymorphism");
        Bird bird = new Crow();
        bird.Speak(); // crow speak

        // Abstraction
        System.Console.WriteLine("\nAbstraction via Abstract class");
        // a.) via abstract class
        // *** Cannot create an instance of the abstract type.
        // Shape shape = new Shape();

        Shape circle = new Circle();
        circle.Draw();
        Circle circle1 = new Circle();
        circle1.Draw();

        // b.) via an interface
        System.Console.WriteLine("\nAbstraction via an interface");
        // *** Cannot create an instance of an interface
        // IVehicle vehicle = new IVehicle();

        IVehicle vehicle = new Bike();
        vehicle.Drive();
        Bike vehicle1 = new Bike();
        vehicle1.Drive(); 
    }
}