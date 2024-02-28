using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        { }
        
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable----
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable----
            
            //The methods should take one string parameter: the respective noise property
            public int Year {  get; set; }
            public string Make {  get; set; }
            public string Model { get; set; }
            public string EngineNoise { get; set; }
            public string HonkNoise { get; set; }
            public bool IsDriveable { get; set; }
        
        public Car(int year, string make, string model, string enginenoise, string honknoise, bool isdriveable) 
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdriveable;
        }
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        public void MakeEngineNoise(string engineNoise) 
        {
            Console.WriteLine($"{Make} {Model} has an engine noise {EngineNoise}.");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{Make} {Model} has an honk noise {HonkNoise}.");
        }

    }
}

