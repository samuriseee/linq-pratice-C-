// init a base main file to run program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinQPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car { model = "Civic", brand = "Honda", year = 2019, price = 20000, numberOfSeats = 5, type = "Sedan" },
                new Car { model = "CRV", brand = "Honda", year = 2019, price = 30000, numberOfSeats = 5, type = "SUV" },
                new Car { model = "Accord", brand = "Honda", year = 2019, price = 25000, numberOfSeats = 5, type = "Sedan" },
                new Car { model = "Camry", brand = "Toyota", year = 1980, price = 30000, numberOfSeats = 5, type = "Sedan" },
                new Car { model = "Corolla", brand = "Toyota", year = 2019, price = 20000, numberOfSeats = 5, type = "Sedan" },
                new Car { model = "Highlander", brand = "Toyota", year = 1980, price = 40000, numberOfSeats = 7, type = "SUV" },
            };

            List<Truck> trucks = new List<Truck>
            {
                new Truck
                {
                    model = "F150", brand = "Ford", year = 2019, price = 30000, loadCapacity = 2000,
                    towingCapacity = 5000
                },
                new Truck
                {
                    model = "F250", brand = "Ford", year = 2019, price = 40000, loadCapacity = 3000,
                    towingCapacity = 6000
                },
                new Truck
                {
                    model = "F350", brand = "Ford", year = 2019, price = 50000, loadCapacity = 4000,
                    towingCapacity = 7000
                },
                new Truck
                {
                    model = "Silverado", brand = "Chevrolet", year = 2019, price = 30000, loadCapacity = 2000,
                    towingCapacity = 5000
                },
                new Truck
                {
                    model = "Colorado", brand = "Chevrolet", year = 2019, price = 20000, loadCapacity = 1500,
                    towingCapacity = 4000
                },
            };
            
            // 2 a 
            var displayCarsFrom100kTo250k = cars.Where(car => car.price >= 10000 && car.price <= 25000);
            foreach (var car in displayCarsFrom100kTo250k)
            {
               Console.WriteLine(car.model + " " + car.brand + " " + car.year + " " + car.price + " " + car.numberOfSeats + " " + car.type);
            }
  
            // 2 b
            var displayCarsProduceBefoe1990 = cars.Where(car => car.year < 1990);
            foreach (var car in displayCarsProduceBefoe1990)
            {
                Console.WriteLine(car.model + " " + car.brand + " " + car.year + " " + car.price + " " + car.numberOfSeats + " " + car.type);
            }
            
            // 2 c
            var groupCarsByBrandandCalculate = cars.GroupBy(car => car.brand)
                .Select(group => new
                {
                    Brand = group.Key,
                    TotalSum = group.Average(car => car.price)
                });
            foreach (var brand in groupCarsByBrandandCalculate)
            {
                Console.WriteLine(brand);
            }
            
            // 3 a
            var sortTruckByYears = trucks.OrderBy(truck => truck.year);
            foreach (var truck in sortTruckByYears)
            {
                Console.WriteLine(truck.model + " " + truck.brand + " " + truck.year + " " + truck.price + " " + truck.loadCapacity + " " + truck.towingCapacity);
            }
            
            
            // 3 b
            var displayTruckBrand = trucks.GroupBy(truck => truck.brand)
                .Select(group => new
                {
                    Brand = group.Key,
                    TotalCount = group.Count()
                });
            foreach (var brand in displayTruckBrand)
            {
                Console.WriteLine(brand);
            }
        }
    }
}
