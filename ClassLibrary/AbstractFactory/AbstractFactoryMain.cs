using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.AbstractFactory
{
   public class AbstractFactoryMain
    {
        public IDictionary Run()
        {
            var factory = new Factory(); 
            
            var morseDictionaryFactory = factory.GetFactory("Morse"); 
            var morse = morseDictionaryFactory.CreateDictionary(); 
            return morse;
        }
    }

}
