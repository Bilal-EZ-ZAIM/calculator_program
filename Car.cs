class Car
{
    public string Name ;
    public string Model;
    public int Year;

    public Car(string newName, string newModel, int newYear)
    {
        Name = newName;
        Model = newModel;
        Year = newYear;
    }

    public void Start()
    {
        Console.WriteLine("The is starting.");
    }

    public string GetNameCar()
    {
        return Name;
    }

    public string GetModelCar()
    {
        return Model;
    }

    public int GetYearCar()
    {
        return Year;
    }

    public void SetNameCar(string newName)
    {
        Name = newName;
    }

    public void SetModelCar(string newModel)
    {
        Model = newModel;
    }

    public void SetYearCar(int newYear)
    {
        Year = newYear;
    }


}


// instance of the class 
// TypeClass  ObjetName = new Type();
// Car Voutire = new Car();
// Voutire.Start();
