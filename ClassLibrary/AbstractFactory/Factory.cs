using ClassLibrary.Dictionary;
using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.AbstractFactory
{
   public class Factory
    {
        public Factory()
        {

        }

        public IFactory GetFactory(string typeOfFactory)
        {
            if (typeOfFactory == "Morse")
            {
                return new MorseDictionaryFactory();
            }

            else
            {
                return null;
            }
        }
    }
}
