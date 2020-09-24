using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleInterfaces
{
    internal class MyObjectList
    {
        private CompareAbleObject[] _objects;
        private int _actIndex = 0;

        public int Length
        {
            get
            {
                return _actIndex;
            }
        }

        public MyObjectList()
        {
            _objects = new CompareAbleObject[10];
        }

        public bool Add(CompareAbleObject objectToAdd)
        {
            if (_actIndex < _objects.Length)
            {
                _objects[_actIndex] = objectToAdd;
                _actIndex++;
                return true;
            }
            return false;
        }

        public Object GetAt(int index)
        {
            if (index >= 0 && index < _objects.Length)
            {
                return _objects[index];
            }
            return null;
        }

        public Object GetHighestElement()
        {
            CompareAbleObject highestElement = null;
            if (_actIndex > 0)
            {
                highestElement = _objects[0];
                for (int i = 0; i < Length; i++)
                {
                    if (highestElement.CompareObj(_objects[i]) < 0)
                    {
                        highestElement = _objects[i];
                    }
                }
            }
            return highestElement;
        }
    }
}