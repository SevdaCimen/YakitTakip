using Core.Entitys;
using Service.Repository;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbperson = new GenericRepository<Person>();
            var dbvehicle = new GenericRepository<FtsVehicle>();

            int i = 0;

            var dbvehicles = dbvehicle.GetAll().ToArray();

            foreach (var p in dbperson.GetAll())
            {
                var car = dbvehicles[i++];
                car.PersonId = p.Id;
                dbvehicle.Update(car);
                Console.WriteLine("Person=" + p.Id + " car=" + car.Id);
            }

            Console.ReadLine();
        }
    }
}
