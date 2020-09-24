using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleInterfaces
{
    internal class Car : CompareAbleObject
    {
        private string name;
        private int _maxSpeed;

        public Car(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override int CompareObj(object other)
        {
            if (_maxSpeed < (other as Car).MaxSpeed)
            {
                return -1;
            }
            else if (_maxSpeed > (other as Car).MaxSpeed)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Ich bin ein Auto der Marke {Name}";
        }
    }
}