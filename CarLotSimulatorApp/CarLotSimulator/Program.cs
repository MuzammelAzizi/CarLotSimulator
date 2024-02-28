using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            

            //OnetWay
            var Urus = new Car();
            Urus.Make = "Lamborghini";
            Urus.Model = "LamboUrus";
            Urus.Year = 2023;
            Urus.EngineNoise = "Vooratata";
            Urus.HonkNoise = "Prrrr";
            Urus.IsDriveable = true;    

            //SecWay
            var M4 = new Car()
            {
                Year = 2024,
                Make = "BMW",
                Model = "M4 Series",
                EngineNoise = "Vrooom taa taaa",
                HonkNoise = "Beep Beep",
                IsDriveable = false
            };

            //ThirdWay
            var Ben = new Car(2020, "Mercedes Benz","G Wagon", "shoootatata", "shhhhhh", true);

            //Set the properties for each of the cars
            //Call each of the methods for each car
            Urus.MakeEngineNoise(Urus.EngineNoise);
            M4.MakeEngineNoise(M4.EngineNoise);



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
