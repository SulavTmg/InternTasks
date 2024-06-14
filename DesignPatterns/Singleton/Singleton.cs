﻿namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;

        private static readonly object _lock = new object();
        private Singleton()
        {
            Console.WriteLine("Singleton is created");
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {

                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }

        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
