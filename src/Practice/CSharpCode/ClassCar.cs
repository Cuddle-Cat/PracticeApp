using System;

class car
{
    public string make;
    public string model;
    public int year;
    public int speed;

    public void accelerate()
    {
        speed += 10;
    }

    public void brake()
    {
        speed -= 10;
        if (speed < 0)
        {
            speed = 0;
        }
    }

    public void PrintStatus()
    {
        Console.WriteLine($"{year} {make} {model} | Speed: {speed} km/h");
    }
}

class ClassCar
{
    public static void Run()
    {
        car car1 = new car
        {
            make = "Toyota",
            model = "Corolla",
            year = 2020,
            speed = 0,
        };
        car car2 = new car
        {
            make = "Ford",
            model = "Mustang",
            year = 2022,
            speed = 0,
        };

        car1.accelerate();
        car1.accelerate();
        car1.brake();
        car1.PrintStatus();
        car2.accelerate();
        car2.accelerate();
        car2.accelerate();
        car2.brake();
        car2.PrintStatus();
    }
}
