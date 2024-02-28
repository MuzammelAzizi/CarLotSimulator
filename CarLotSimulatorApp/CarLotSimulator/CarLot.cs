using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> Parking { get; set; } = new List<Car>();

        public void CheckCars() 
        {
            foreach (var car in ParkingLot) 
            {
                Console.WriteLine($"This is car {car.Make} {car.Model}, made in the year {car.Year}.");

                if (car.Make == "") ;
            }
        }
    }
}
