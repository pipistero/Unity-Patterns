using UnityEngine;

namespace Patterns.Flyweight
{
    public class HeavyClass
    {
        private int _randomNumber;
        private SomeData _someData;

        public HeavyClass()
        {
            _randomNumber = Random.Range(100, 1000);
            _someData = new SomeData();
        }
    }
}