using ClassLibraryForTranslationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTranslationService.Dictionary
{
    public class MorseDictionaryFactory : IFactory
    {
        public IDictionary CreateDictionary()
        {
            return new MorseDictionary("");
        }

    }
}
