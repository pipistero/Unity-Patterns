using UnityEngine;

namespace Patterns.Flyweight
{
    public class FlyweightClass
    {
        private int _randomNumber;
        private SomeData _someData;

        public FlyweightClass(SomeData someData)
        {
            _randomNumber = Random.Range(100, 1000);
            _someData = someData;
        }
    }
}