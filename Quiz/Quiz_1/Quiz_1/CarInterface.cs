using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1
{
    public interface CarInterface
    {
        Car[] initListCar(Car car);

        void printListCar(Car[] cars);

        Car findCarByType(Car[] listOfCar, string type);

        Car findCarByNoPol(Car[] listOfCar, string nopol);

        double totalPendapatan(Car[] listOfCar, string type);
    }
}
