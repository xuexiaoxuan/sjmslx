using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22享元模式
{
    public class FlyweightFactory
    {
        private Hashtable _cache = new Hashtable();
        public FlyweightFactory() {
            _cache.Add("X", new ConcreteFlyweight());
            _cache.Add("Y", new ConcreteFlyweight());
            _cache.Add("Z", new ConcreteFlyweight());
        }
        public Flyweight GetFlyweight(string key) {
            return (Flyweight)_cache[key];
        }
    }
}