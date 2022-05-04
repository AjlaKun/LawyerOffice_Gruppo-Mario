using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice_Gruppo_Mario.Translation
{
    public class TranslationFactory
    {
        public static ITranslator GetTranslator(LANGUAGE language)
        {
            switch (language)
            {
                case LANGUAGE.ENG:
                    return new EnglishTranslator();
                    break;
                case LANGUAGE.GERMAN:
                    return new GermanTranslator();
                    break;
                case LANGUAGE.SPANISH:
                    return new SpanishTranslator();
                    break;
                default: return null;
            }

        }

    }
}

