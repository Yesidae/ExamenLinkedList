using LinkedList.Logic;

Console.WriteLine("***** CARS *****");
var cars = new DoubleList<Car>();

var car1 = new Car { Brand = "BMW", Model = "I8", Year = 2021, Color = "Black", Price = 25000000 };
var car2 = new Car { Brand = "AUDI", Model = "A8", Year = 2019, Color = "Red", Price = 50000000 };
var car3 = new Car { Brand = "MERCEDES BENZ", Model = "MERCEDES W8", Year = 2023, Color = "Black", Price = 48000000 };
var car4 = new Car { Brand = "ASTON MARTIN", Model = "ONE-77", Year = 2024, Color = "Blue", Price = 12550000 };
var car5 = new Car { Brand = "BMW", Model = "XM5", Year = 2020, Color = "White", Price = 65580000 };
var car6 = new Car { Brand = "BMW", Model = "XM6", Year = 2015, Color = "Red", Price = 89200000 };
var car7 = new Car { Brand = "ASTON MARTIN", Model = "SERIE 1", Year = 2011, Color = "Black", Price = 96800000 };
var car8 = new Car { Brand = "AUDI", Model = "A1", Year = 2018, Color = "Red", Price = 97600000 };
var car9 = new Car { Brand = "AUDI", Model = "A3", Year = 2015, Color = "Blue", Price = 130040000 };
var car10 = new Car { Brand = "MERCEDES BENZ", Model = "AMG A 45", Year = 2022, Color = "Blue", Price = 200000000 };
var car11 = new Car { Brand = "MERCEDES BENZ", Model = "CITAN", Year = 2020, Color = "Black", Price = 190000000 };
var car12 = new Car { Brand = "ASTON MARTIN", Model = "DB11", Year = 2016, Color = "White", Price = 199000000 };

cars.Add(car1);
cars.Add(car2);
cars.Add(car3);
cars.Add(car4);
cars.Add(car5);
cars.Add(car6);
cars.Add(car7);
cars.Add(car8);
cars.Add(car9);
cars.Add(car10);
cars.Add(car11);
cars.Add(car12);

Console.WriteLine("Card List =>");
Console.WriteLine(cars);

Console.WriteLine("");
Console.WriteLine("Only cars BMW");
Console.WriteLine(cars.GetBrand("BMW"));

Console.WriteLine("");
Console.WriteLine("Only cars 2019 - 2022");
Console.WriteLine(cars.GetYear(2019, 2022));

Console.WriteLine("");
Console.WriteLine("Only cars 855000 USD - 1500000 USD");
Console.WriteLine(cars.GetPrice(855000, 1500000));

Console.WriteLine("");
var values = cars.GetMinMax(cars);
Console.WriteLine("Car whit minimun value is: ");
Console.WriteLine(values[0]);
Console.WriteLine("");
Console.WriteLine("Car whit maximun value is: ");
Console.WriteLine(values[1]);



