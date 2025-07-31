namespace inheritance
{
    /* INHERITANCE  
        * When a class reuse the properties and methods of other class.
        * Base Class  - Parent
        * Derived Class - Child

        *** Remember 
        * Reusability - biggest advantage of inheritance
    */
    public class Animal   // Parent Class
    {
        public void Eat()
        {
            System.Console.WriteLine("Animal is eating");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            System.Console.WriteLine("Dog is barking");
        }
    }
}