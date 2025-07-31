
using polymorephism;
using classObjects;
using AccountA = encapsulations.Account;
using inheritance;
using abstraction;
using oops_abstraction_encapsulation;
namespace oops;

class Program
{
    public static void Oops()
    {
        // Class & Objects
        System.Console.WriteLine("Classes & Objects");
        Car myCar = new Car();
        myCar.Color = "Red";
        myCar.Drive();

        // Encapsulation
        System.Console.WriteLine("\nEncapsulation");
        AccountA myAccount = new AccountA();
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

    public static void Abstration_Encapsulation()
    {
        Account account = new SavingAccount(); // abstraction in action

        account.Deposit(1000);
        account.Withdraw(300);

        // account.balance;  ERROR

        // must use GetBalance() (through encapsulation)
        SavingAccount realAccount = (SavingAccount)account;
        Console.WriteLine($"Current Balance : {realAccount.GetBalance()}");
    }
    static void Main(string[] args)
    {
        // Oops();  
    }
}