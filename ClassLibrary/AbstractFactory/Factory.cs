using ClassLibraryForTranslationService.Dictionary;
using ClassLibraryForTranslationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTranslationService.AbstractFactory
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
