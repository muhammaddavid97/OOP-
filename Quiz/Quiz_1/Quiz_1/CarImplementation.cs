using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1
{
    public class CarImplementation : CarInterface
    {
        public Car findCarByNoPol(Car[] listOfCar, string nopol)
        {
            for (int i = 0; i < listOfCar.Length; i++)
            {
                if (listOfCar[i].NoPolisi == nopol)
                {
                    return listOfCar[i];
                }
            }

            return null;
        }

        public Car findCarByType(Car[] listOfCar, string type)
        {
            for (int i = 0; i < listOfCar.Length; i++)
            {
                if (listOfCar[i].Type == type)
                {
                    return listOfCar[i];
                }
            }

            return null;
        }

        public Car[] initListCar(Car car)
        {
            Car[] cars = new Car[]
            {
                car
            };

            return cars;
         }

        public void printListCar(Car[] cars)
        {
            foreach(Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public double totalPendapatan(Car[] listOfCar, string type)
        {
            double total = 0.0; 

            for (int i = 0; i < listOfCar.Length; i++)
            {
                if (listOfCar[i].Type == type)
                {
                   total += listOfCar[i].totalPendapatan();
                }
            }

            return total;
        }
    }
}
