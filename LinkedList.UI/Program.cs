using LinkedList.logic;

// Crear lista de automóviles
YourLinkedList carList = new YourLinkedList();

// Agregar 12 vehículos con diferentes propiedades
carList.Add(new CarList { Brand = "Toyota", Model = "Corolla", Year = 2020, Color = "Azul", Price = 50000000 });
carList.Add(new CarList { Brand = "Toyota", Model = "Yaris", Year = 2019, Color = "Rojo", Price = 60000000 });
carList.Add(new CarList { Brand = "Mazda", Model = "3", Year = 2021, Color = "Azul", Price = 120000000 });
carList.Add(new CarList { Brand = "Mazda", Model = "CX-5", Year = 2018, Color = "Negro", Price = 130000000 });
carList.Add(new CarList { Brand = "Nissan", Model = "Versa", Year = 2020, Color = "Gris", Price = 60000000 });
carList.Add(new CarList { Brand = "Nissan", Model = "Sentra", Year = 2021, Color = "Rojo", Price = 90000000 });
carList.Add(new CarList { Brand = "Ford", Model = "Fiesta", Year = 2019, Color = "Blanco", Price = 55000000 });
carList.Add(new CarList { Brand = "Ford", Model = "Focus", Year = 2021, Color = "Gris", Price = 100000000 });
carList.Add(new CarList { Brand = "Toyota", Model = "Hilux", Year = 2019, Color = "Negro", Price = 220000000 });
carList.Add(new CarList { Brand = "Mazda", Model = "2", Year = 2018, Color = "Blanco", Price = 48000000 });
carList.Add(new CarList { Brand = "Nissan", Model = "Kicks", Year = 2020, Color = "Azul", Price = 180000000 });
carList.Add(new CarList { Brand = "Ford", Model = "Mustang", Year = 2021, Color = "Rojo", Price = 240000000 });

// Prueba GetBrand
YourLinkedList toyotaCars = carList.GetBrand("Toyota");
Console.WriteLine("Toyota Cars:");
Console.WriteLine(toyotaCars.ToString());

// Prueba GetModel
YourLinkedList cars2019 = carList.GetYear(2019, 2019);
Console.WriteLine("\nCars from 2019:");
Console.WriteLine(cars2019.ToString());

// Prueba GetPrice
YourLinkedList mediumPriceCars = carList.GetPrice(60000000, 120000000);
Console.WriteLine("\nCars between 60 million and 120 million:");
Console.WriteLine(mediumPriceCars.ToString());

// Prueba GetSeveralFilters
YourLinkedList filteredCars = carList.GetSeveralFilters("Toyota", "*", "Azul", 2020, 240000000);
Console.WriteLine("\nFiltered Cars (Toyota, Blue, 2020 or newer):");
Console.WriteLine(filteredCars.ToString());

// Prueba GetMinMax
CarList[] minMax = carList.GetMinMax(carList);
Console.WriteLine("\nCar with minimum price: {0} | Car with maximun price: {1}", minMax[0].ToString(), minMax[1].ToString());
