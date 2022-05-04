using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice_Gruppo_Mario.Translation
{
    public class EnglishTranslator : ITranslator
    {
        public string Translate(string text)
        {
            if (text == "HI")

            {
                text = "ciao da English translator";
            }
            return text;
        }

    }
    public class SpanishTranslator : ITranslator
    {
        public string Translate(string text)
        {
            if (text == "HOLA")

            {
                text = "ciao da Spanish translator";
            }
            return text;

        }
    }
    public class GermanTranslator : ITranslator
    {
        public string Translate(string text)
        {
            if (text == "HALLO")

            {
                text = "ciao da German translator";
            }
            return text;
        }
    }
}
