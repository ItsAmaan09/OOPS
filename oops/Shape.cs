namespace abstraction
{
    /* ABSTRACTION
        * Hide complex things and show only important things.
        * abstraction acheive via :
            a.) Abstract Class
            b.) Interface
    */

    /// <summary>
    ///  Abstraction via Abstract Class
    /// </summary>
    public abstract class Shape
    {
        public abstract void Draw(); // no body
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle.");
        }
    }
    /// <summary>
    /// Abstraction via Interface
    /// </summary>
    public interface IVehicle
    {
        public void Drive();
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is driving");
        }
    }
}

/*  Difference b/w Abstract Class and an Interface 

        Abstract Class                                                          Interface

    1. Can have logic.                                                      No logic allowed.
    2. Can have fields.                                                     No fields, only methods
    3. Single class inheritance                                         Multiple interface

*/