using System.Xml.Linq;

public abstract class Shape
{
    public int whith { get; set; }
    protected int length { get; set; }
    //public Shape(int whith)
    //{
    //    this.whith = whith;
    //}
    public virtual void Draw()
    {
        Console.WriteLine("Drawing the shape!");
    }
    public  void Calculate()
    {
        Console.WriteLine("Drawing the shape!");
    }

}
public class Rectangle : Shape
{
    //public Rectangle():base(int whith)
    //{
        
    //}
    //method overriding
    public override void Draw()
    {
        Console.WriteLine("Drawing rectangle!");
        base.Draw();
    }
}

public class Triangle : Shape
{
    //method hiding
    public new void Calculate()
    {
        Console.WriteLine("Drawing New the shape!");
    }
}

// beacause of sealed we can't inheratance the class

public sealed class Circle : Shape
{
    // beacause of sealed we can't override the method
    public sealed override void Draw()
    {
        Console.WriteLine("Drawing Circle!");
        base.Draw();
    }
}



//interface
public interface INamed
{
    string Name { get; set; }

    void PrintName();
    void Notify();
}
public interface INotify
{
    void Notify();
}
public class Car : INamed, INotify
{
    public string Name { get; set; }

    

    public void PrintName()
    {
        Console.WriteLine(Name);
    }

    //explicit
    void INamed.Notify()
    {
        Console.WriteLine("Notify via INamed!");
    }
    //explicit
    void INotify.Notify()
    {
        Console.WriteLine("Notify me via INotify!");
    }
}





class Program
{
    static void Main(string[] args)
    {
        var rect = new Rectangle();
        //var tri = new Triangle();
       // var circ = new Circle();

       // rect.Draw();
       // tri.Draw();
       // tri.Calculate();
       // circ.Draw();


        if (rect is Rectangle) {
            Console.WriteLine("rect is Rectangle");
        }



        //interface  explicit


       // var car = new Car();
       // INamed nameNotify = car;
       // nameNotify.Notify();
       // INotify Notify = car;
       // Notify.Notify();






        Console.ReadKey();
    }
}