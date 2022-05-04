using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice_Gruppo_Mario.Translation
{
    public class TranslationOnlineStore
    {

        public TranslationOnlineStore()
        {

        }
        public string Translate(LANGUAGE lang, string text)
        {

            var translator = TranslationFactory.GetTranslator(lang);
            return translator.Translate(text);

        }
    }
}
