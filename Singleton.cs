using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Singleton
    {
        //1. Declear pravite static field
        private static Singleton instance;

        //2. Private Constructor
        private Singleton() { }

        //3. GetInstance method which will be access from outside scope
        //will return instance always when invoked 
        //else return already created
        public static Singleton GetInstance()
        { 
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        //4. any business logic method

        

    }
}
