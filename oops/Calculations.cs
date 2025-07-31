namespace polymorephism
{
    /* POLYMORPHISM - one name many forms
        * A method can have multiple forms - either at complile time (overloading)
        or at runtime (overriding)


        *** Overload - same name, diff parameters
               Override - child class create own version
    */

    // 1: Method overloading - Complile time
    public class Calculations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c) // 1.same name with same returnType but no of params increase 
        {
            return a + b + c;
        }
        public double Add(double a, double b) // 2. same name with different returnType
        {
            return a + b;
        }
        public double Add(double a, int b) // 3. same name with same returnType but params different
        {
            return a + b;
        }
        public double Add(int a, double b) // 4. same name with same returnType but params position change
        {
            return a + b;
        }
    }

    // 2: Method overriding - Run time 
    // child will be override method of parent
    public class Bird
    {
        public virtual void Speak()
        {
            System.Console.WriteLine("Bird speaks.");
        }
    }

    public class Crow : Bird
    {
        public override void Speak()
        {
            System.Console.WriteLine("Crow speak .");
        }
    }
}