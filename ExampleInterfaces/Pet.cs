using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleInterfaces
{
    internal class Pet : CompareAbleObject
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public override int CompareObj(object other)
        {
            if (_age < (other as Pet).Age)
            {
                return -1;
            }
            else if (_age > (other as Pet).Age)
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
            return $"Ich bin ein Pet und heiße {Name}";
        }
    }
}