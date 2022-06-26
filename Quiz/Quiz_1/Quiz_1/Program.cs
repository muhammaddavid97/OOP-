using Quiz_1;

Suv suv1 = new Suv("D 1001 UM", 2015, "SUV", 500000, 100000);
Suv suv2 = new Suv("D 1002 UM", 2019, "SUV", 500000, 100000);

Angkot angkot1 = new Angkot("D 55 UJ", 2016, "ANGKOT", 4500, 35);
Angkot angkot2 = new Angkot("D 55 UJ", 2015, "ANGKOT", 4500, 40);

Taxi taxi1 = new Taxi("D 88 UK", 2018, "TAXI", 5, 4500, 40, 10000);
Taxi taxi2 = new Taxi("D 87 UK", 2018, "TAXI", 10, 4500, 100, 10000);

Car[] cars = new Car[]
{
    suv1,
    suv2,
    angkot1,
    angkot2,
    taxi1, 
    taxi2
}; 

// membuat instance untuk kelas CarImplementation
CarImplementation carImplementation = new CarImplementation();

/*foreach(var item in cars)
{
    carImplementation.initListCar(item);

    var listsCars = carImplementation.initListCar(item);

    carImplementation.printListCar(listsCars);
}*/

Console.WriteLine();

//Console.WriteLine("Mencari dan menampilkan data mobil berdasarkan type");
//Console.WriteLine(carImplementation.findCarByType(cars, "ANGKOT").ToString());
//Console.WriteLine(carImplementation.findCarByNoPol(cars, "D 1002 UM").ToString());
Console.WriteLine("Total pendapatan : " + carImplementation.totalPendapatan(cars, "TAXI"));