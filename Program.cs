
class Program
{

    static void Main(string[] args)
    {
        // Creating an instance of the Car class
        // NameClass objectName = new NameClass();
        Car Car1 = new Car(newName:"BMW", newModel:"X5", newYear:2022);
        Car1.Start();
        Console.WriteLine("Car Name: " + Car1.GetNameCar());
        Console.WriteLine("Car Model: " + Car1.GetModelCar());
        Console.WriteLine("Car Year: " + Car1.GetYearCar());
        Car1.SetNameCar("Audi");
        Car1.SetModelCar("Q7"); 
        Car1.SetYearCar(2023);
        Console.WriteLine("Updated Car Name: " + Car1.GetNameCar());
        Console.WriteLine("Updated Car Model: " + Car1.GetModelCar());
        Console.WriteLine("Updated Car Year: " + Car1.GetYearCar());

        Console.WriteLine("Hello, World!");
    }
}

