using System;

namespace Masny.Patterns.Creational
{
    class Singleton
    {
        private static Singleton _instance;

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }

    public class SingletonPattern
    {
        public void Start()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
        }
    }
}
