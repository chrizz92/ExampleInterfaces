using System;

namespace ExampleInterfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pet pet1 = new Pet();
            Pet pet2 = new Pet();
            Pet pet3 = new Pet();
            MyObjectList myPetList = new MyObjectList();
            //MyObjectList myIntList = new MyObjectList();
            //myIntList.Add(1);
            //myIntList.Add(2);
            //myIntList.Add(3);

            pet1.Name = "Hund";
            pet2.Name = "Katze";
            pet3.Name = "Maus";
            pet1.Age = 4;
            pet2.Age = 12;
            pet3.Age = 7;
            object o = pet1;

            Console.WriteLine(pet1.ToString());
            Console.WriteLine(o);

            myPetList.Add(pet1);
            myPetList.Add(pet2);
            myPetList.Add(pet3);

            Console.WriteLine("Größtes Object: " + myPetList.GetHighestElement());

            for (int i = 0; i < myPetList.Length; i++)
            {
                Console.WriteLine(myPetList.GetAt(i));
            }

            MyObjectList myCarList = new MyObjectList();
            myCarList.Add(new Car("BMW", 300));
            myCarList.Add(new Car("Audi", 200));
            myCarList.Add(new Car("Mercedes", 350));
            myCarList.Add(new Car("Audi", 200));
            Console.WriteLine(myCarList.GetHighestElement());
        }
    }
}