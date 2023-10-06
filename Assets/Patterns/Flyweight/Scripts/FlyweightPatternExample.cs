using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Flyweight
{
    public enum ClassType
    {
        Flyweight = 1,
        Heavy = 2
    }
    
    public class FlyweightPatternExample : MonoBehaviour
    {
        [SerializeField] private int _totalObjects = 10000000;
        [SerializeField] private ClassType _classType = ClassType.Flyweight;

        private List<FlyweightClass> _flyweightObjects = new List<FlyweightClass>();
        private List<HeavyClass> _heavyObjects = new List<HeavyClass>();
        
        private void Start()
        {
            switch (_classType)
            {
                case ClassType.Flyweight:

                    SomeData someData = new SomeData();
                    
                    for (int i = 0; i < _totalObjects; i++)
                    {
                        FlyweightClass newFlyweightObject = new FlyweightClass(someData);
                        _flyweightObjects.Add(newFlyweightObject);
                    }
                    
                    break;
                
                case ClassType.Heavy:
                    
                    for (int i = 0; i < _totalObjects; i++)
                    {
                        HeavyClass newHeavyObject = new HeavyClass();
                        _heavyObjects.Add(newHeavyObject);
                    }
                    
                    break;
            }
        }
    }
}