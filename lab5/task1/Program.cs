using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public abstract class Vehicle
    {
        public double Speed { get; set; }
        public int Capacity { get; set; }

        public abstract void Move();
    }

    
    public class Human
    {
        public double Speed { get; set; }

        public void Move()
        {
            Console.WriteLine("Human is moving on foot.");
        }
    }

    
    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Car is moving on the road.");
        }
    }

    public class Bus : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bus is moving on the road.");
        }
    }

    public class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Train is moving on the railway.");
        }
    }
    public class Route
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }

        public Route(string startPoint, string endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
    }

    
    public class TransportNetwork
    {
        private List<Vehicle> vehicles;

        public TransportNetwork()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void MoveAllVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }

        public void OptimizeRoute(Vehicle vehicle, Route route)
        {
           
            Console.WriteLine($"Optimizing route for {vehicle.GetType().Name} from {route.StartPoint} to {route.EndPoint}.");
        }

        public void PassengerHandling(Vehicle vehicle, int passengers)
        {
           
            Console.WriteLine($"Handling passengers for {vehicle.GetType().Name}: {passengers} passengers onboard.");
        }
    }

    class Program
    {
        static void Main()
        {
            TransportNetwork transportNetwork = new TransportNetwork();

            Car car = new Car { Speed = 100, Capacity = 4 };
            Bus bus = new Bus { Speed = 60, Capacity = 40 };
            Train train = new Train { Speed = 120, Capacity = 200 };

            transportNetwork.AddVehicle(car);
            transportNetwork.AddVehicle(bus);
            transportNetwork.AddVehicle(train);

            transportNetwork.MoveAllVehicles();

            Route route = new Route("City A", "City B");

            transportNetwork.OptimizeRoute(car, route);
            transportNetwork.OptimizeRoute(bus, route);
            transportNetwork.OptimizeRoute(train, route);

            transportNetwork.PassengerHandling(car, 3);
            transportNetwork.PassengerHandling(bus, 35);
            transportNetwork.PassengerHandling(train, 180);
        }
    }
}
